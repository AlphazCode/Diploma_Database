import numpy as np
from bs4 import BeautifulSoup
import pandas as pd
import os
import requests

path = os.path.dirname(os.getcwd()) + '\\Sources\\'
dest_codes_path = path + 'transformed\\airlines.csv'


def parse_to_csv(url):
    page = requests.get(url)
    soup = BeautifulSoup(page.content, "html.parser")
    data = soup.find_all("tr")
    code = "<table><tbody>"
    for i in data:
        code += str(i)
    code += "</tbody></table>"
    df = pd.DataFrame(np.concatenate(pd.read_html(code)),columns=['IATA','ICAO','Airline', 'Callsign', 'Country']).drop_duplicates()
    print(df)
    df.to_csv(dest_codes_path, index=False, header=True, mode='w')



if __name__ == "__main__":
    if os.path.exists(dest_codes_path):
        print("File already exists")
    else:
        parse_to_csv("http://www.flugzeuginfo.net/table_airlinecodes_airline_en.php")
