import os
import re
import time
import threading
import pandas as pd
from urllib.error import HTTPError
from pathlib import Path
from sqlalchemy import create_engine
import requests
from bs4 import BeautifulSoup as soup
from fake_useragent import UserAgent

engine = create_engine('mssql+pyodbc://localhost/Airport_DB?driver=SQL+Server+Native+Client+11.0')
ua = UserAgent()
df = pd.DataFrame(columns=["plane_code", "AIRCRAFT", "AIRLINE", "OPERATOR", "TYPE CODE", "Code", "MODE S"])
path = str(Path(os.path.dirname(os.path.abspath(__file__))).parent) + '\\Sources\\'
source_path = path + 'flights_short.csv'
dest_path = path + '\\transformed\\aircrafts.csv'

file = pd.read_csv(source_path, usecols=['TAIL_NUMBER'],nrows=200).drop_duplicates(subset='TAIL_NUMBER',
                                                                         keep='first').sort_values(by='TAIL_NUMBER').reset_index()
file = file.dropna()
planes = file['TAIL_NUMBER'].tolist()
def parse_to_csv(url, agent,b=False):
    print(url)
    time.sleep(0.5)
    req = requests.get(url, headers={'User-Agent': agent})
    if req.status_code == 429:
        if b==True:
            return
        time.sleep(2)
        return parse_to_csv(url, ua.random,b=True)
    data = soup(req.content, "html.parser")
    try:
        if re.search(r'flightradar', str(data.title), re.IGNORECASE):
            col = data.find("div", {"id": "cnt-aircraft-info"})
            codes = col.find_all("span", {"class": "details"})[:7]
            for i in codes:
                if i.text.strip() == "-":
                    return
            plane = str(url.split('/')[-1])
            aircraft = [i.text.strip() for i in codes[:4] + codes[5:]]
            aircraft.insert(0, plane)
            df.loc[len(df)] = aircraft
            df.to_csv(dest_path, index=False, mode='a',header=False)
        else:
            return

    except AttributeError:
        return

threads = 8
coefficient = len(planes) // threads


def divided_array(start: int):
    for i in range(int(coefficient * int(start)), int(coefficient * (int(start) + 1))):
        parse_to_csv(f"https://www.flightradar24.com/data/aircraft/{planes[i]}", ua.random)

def main():
    try:
        for i in range(threads ):
            threading.Thread(target=divided_array, args=(i,)).start()
    except KeyboardInterrupt:
        for i in threading.enumerate():
            i.quit()

    for i in threading.enumerate():
        if not i.is_alive():
            i.join()


if __name__ == "__main__":
    if os.path.exists(dest_path):
        print("File already exists")
    else:
        main()
