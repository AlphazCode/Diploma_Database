import datetime
import hashlib
import os
import re
import zipfile
import easygui
import pandas as pd
from pyisemail import is_email
import pycountry
import getpass
from pathlib import Path
import sqlalchemy as sa

engine = sa.create_engine('mssql+pyodbc://localhost/Airport_DB?driver=SQL+Server+Native+Client+11.0')
pd.set_option('display.max_rows', None)
pd.set_option('display.max_columns', None)
pd.set_option('display.width', None)
pd.set_option('display.max_colwidth', None)


def top_flights():
    data = pd.read_sql_query("SELECT TOP 10 FROM sFlight.Flight as F LEFT JOIN sFlight.Flight_Emergency as E On F.FLIGHT_NUMBER = E.FLIGHT_NUMBER; ORDER BY [FLIGHT_NUMBER] DESC",
        engine)

    if data.empty:
        print("Table Flight is empty")
    else:
        print(data.to_markdown())

def top_airport():
    data = pd.read_sql_query("SELECT TOP 10 FROM sFlight.Flight as F LEFT JOIN sFlight.Flight_Emergency as E On F.FLIGHT_NUMBER = E.FLIGHT_NUMBER; ORDER BY [FLIGHT_NUMBER] DESC",
        engine)

    if data.empty:
        print("Table Flight is empty")
    else:
        print(data.to_markdown())

def top_client():
    data = pd.read_sql_query("SELECT TOP 10 FROM sFlight.Flight as F LEFT JOIN sFlight.Flight_Emergency as E On F.FLIGHT_NUMBER = E.FLIGHT_NUMBER; ORDER BY [FLIGHT_NUMBER] DESC",
        engine)

    if data.empty:
        print("Table Flight is empty")
    else:
        print(data.to_markdown())

def top_flights():
    data = pd.read_sql_query("SELECT TOP 10 FROM sFlight.Flight as F LEFT JOIN sFlight.Flight_Emergency as E On F.FLIGHT_NUMBER = E.FLIGHT_NUMBER; ORDER BY [FLIGHT_NUMBER] DESC",
        engine)

    if data.empty:
        print("Table Flight is empty")
    else:
        print(data.to_markdown())


def interface():
    while True:
        print("\n\n")
        print("1. List of flights")
        print("2. List of clients")
        print("3. List of airplanes")
        print("4. List of airlines")
        print("5. List of airports")
        value = input("Choose your option: ")
        if value == "exit":
            return
        value = int(value)
        if value == 1:
            all_users()
        elif value == 2:
            all_restaurants()
        elif value == 3:
            new_user()
        elif value == 4:
            new_restaurant()
        elif value == 5:
            all_reports()
        elif value == 6:
            collect_reports()

interface()
