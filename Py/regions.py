from selenium import webdriver
import pandas as pd
import os
import time
import threading

options = webdriver.ChromeOptions()
options.add_argument("--headless")
options.add_argument("--disable-extensions")
chrome_exe = os.path.dirname(os.path.realpath(__file__))

path = os.path.dirname(os.getcwd()) + '\\Sources\\'
source_path = path + 'airports.csv'
dest_countries_path = path + 'countries_separated.csv'
dest_regions_path = path + '\\transformed\\regions.csv'

file = pd.read_csv(source_path, usecols=['iso_country']).drop_duplicates(subset='iso_country',
                                                                         keep='first').reset_index()
file = file.dropna()
file.to_csv(dest_countries_path, columns=['iso_country'], index=False)
countries = file['iso_country'].tolist()


def parse_to_csv(browser, first=False):
    time.sleep(2)
    df = pd.read_html(browser.page_source)[2]
    df = df[['3166-2 code', 'Subdivision name']]
    df.replace(r"[\(\[].*?[\)\]]|[\*]", "", regex=True, inplace=True)
    df.to_csv(dest_regions_path, index=False, header=(True if first else False), mode=('w' if first else 'a'))

coefficient = len(countries)//4

def divided_array(browser, start):
    for i in range(int(coefficient * start), int(coefficient * (start+1))):
        browser.get(f"https://www.iso.org/obp/ui#iso:code:3166:{countries[i]}")
        parse_to_csv(browser, True) if i == 0 else parse_to_csv(browser)
        print(countries[i])

def main():
    threading.Thread(target=divided_array, args=(webdriver.Chrome(executable_path=chrome_exe + r'\chromedriver.exe', options=options), 0)).start()
    threading.Thread(target=divided_array, args=(webdriver.Chrome(executable_path=chrome_exe + r'\chromedriver.exe', options=options), 1)).start()
    threading.Thread(target=divided_array, args=(webdriver.Chrome(executable_path=chrome_exe + r'\chromedriver.exe', options=options), 2)).start()
    threading.Thread(target=divided_array, args=(webdriver.Chrome(executable_path=chrome_exe + r'\chromedriver.exe', options=options), 3)).start()


    for i in threading.enumerate():
        if not i.is_alive():
            i.join()

if __name__ == "__main__":
    if os.path.exists(dest_regions_path):
        print("File already exists")
    else:
        main()