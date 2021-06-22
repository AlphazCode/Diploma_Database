from bs4 import BeautifulSoup
from selenium import webdriver
import pandas as pd
import os
import time
import threading

options = webdriver.ChromeOptions()
options.add_argument("--headless")
options.add_argument("--disable-extensions")
chrome_exe = os.path.dirname(os.path.realpath(__file__))

path = os.path.dirname(os.getcwd()) + '\Sources\\'
source_path = os.path.join(path, 'flights_short.csv')
dest_path = os.path.join(path, '\\transformed\\planes.csv')

file = pd.read_csv(source_path, usecols=['TAIL_NUMBER']).drop_duplicates(subset='TAIL_NUMBER',
                                                                         keep='first').reset_index()
file = file.dropna()
planes = file['TAIL_NUMBER'].tolist()

df = pd.DataFrame(columns=["AIRCRAFT","AIRLINE","OPERATOR", "TYPE CODE","Code", "Code","MODE S"])
def parse_to_csv(browser):
    data = BeautifulSoup(browser.page_source,"html.parser")
    col = data.find("div",{"id": "cnt-aircraft-info"})
    codes = col.find_all("span",{"class": "details"})[:7]
    df.append(pd.Series([i.text.strip() for i in codes], index = df.columns), ignore_index=True)
    # df = df[['3166-2 code', 'Subdivision name']]
    # df.replace(r"[\(\[].*?[\)\]]|[\*]", "", regex=True, inplace=True)
    # df.to_csv(dest_path, index=False, header=(True if first else False), mode=('w' if first else 'a'))
    print(df)

coefficient = len(planes)//4

def divided_array(browser, start):
    #for i in range(int(coefficient * start), int(coefficient * (start+1))):
    browser.get(f"https://www.flightradar24.com/data/aircraft/9n-ain")
    parse_to_csv(browser)

divided_array(webdriver.Chrome(executable_path=chrome_exe + r'\chromedriver.exe', options=options),1)
# thread1 = threading.Thread(target=divided_array, args=(webdriver.Chrome(executable_path=chrome_exe + r'\chromedriver.exe', options=options), 0)).start()
# thread2 = threading.Thread(target=divided_array, args=(webdriver.Chrome(executable_path=chrome_exe + r'\chromedriver.exe', options=options), 1)).start()
# thread3 = threading.Thread(target=divided_array, args=(webdriver.Chrome(executable_path=chrome_exe + r'\chromedriver.exe', options=options), 2)).start()
# thread4 = threading.Thread(target=divided_array, args=(webdriver.Chrome(executable_path=chrome_exe + r'\chromedriver.exe', options=options), 3)).start()
#
#
# for i in threading.enumerate():
#     if not i.is_alive():
#         i.join()



