/* Airport
CREATE DATABASE

USE master
DROP DATABASE IF EXISTS Airport_DB

CREATE DATABASE Airport_DB
ON(
	Name = airport,
	FileName = 'D:\_IPPT\Diploma\Database\airport.mdf',
	Size =8192KB,
	MAXSIZE = UNLIMITED,
	FILEGROWTH = 65536KB)
Log ON(
	Name = airport_log,
	FileName = 'D:\_IPPT\Diploma\Database\airport_log.ldf',
	Size =10,
	MAXSIZE = UNLIMITED,
	FILEGROWTH = 65536KB)

USE Airport_DB

DROP TABLE IF EXISTS Regions
CREATE TABLE Regions(
	iso_code NVARCHAR(7),
	name NVARCHAR(100)
)
*/
/*---------------------------------------------------

                CREATE SCHEMA Person

---------------------------------------------------*/
USE Airport_DB



DROP TABLE IF EXISTS sPerson.Email
DROP TABLE IF EXISTS sPerson.Number
DROP TABLE IF EXISTS Aircraft
DROP TABLE IF EXISTS sFlight.Flight_Emergency
DROP TABLE IF EXISTS sFlight.Ticket
DROP TABLE IF EXISTS sPerson.Person

DROP TABLE IF EXISTS sFlight.Flight

DROP TABLE IF EXISTS sAirport.Airport
DROP TABLE IF EXISTS sAirport.Airline

DROP SCHEMA IF EXISTS sFlight
DROP SCHEMA IF EXISTS sAirport
DROP SCHEMA IF EXISTS sPerson
DROP VIEW IF EXISTS vPerson
DROP VIEW IF EXISTS vTrip
DROP VIEW IF EXISTS vEmergencyFlights
GO
CREATE SCHEMA sPerson
GO



/*---------------------------------------------------

                CREATE TABLE Person

---------------------------------------------------*/



CREATE TABLE sPerson.Person
(
    ID INT IDENTITY CONSTRAINT PK_person_id PRIMARY KEY,
    first_name VARCHAR(40) NOT NULL,
    middle_name VARCHAR(40) NULL,
    last_name VARCHAR(40) NOT NULL,
    date_of_birth DATE NOT NULL,
    gender CHAR(1) CHECK (gender IN('F','M')) NULL,
    mofified_date DATETIME DEFAULT CURRENT_TIMESTAMP
)



/*---------------------------------------------------

                CREATE TABLE Email

---------------------------------------------------*/
CREATE TABLE sPerson.Email
(
    email VARCHAR(255) NOT NULL CHECK(Email LIKE '%@%.%') CONSTRAINT PK_email PRIMARY KEY,
    person_ID INT CONSTRAINT FK_person_email_id FOREIGN KEY REFERENCES sPerson.Person(ID),
    isActive BIT NOT NULL DEFAULT 1,
    mofified_date DATETIME DEFAULT CURRENT_TIMESTAMP
)

/*---------------------------------------------------

                CREATE TABLE Number

---------------------------------------------------*/
CREATE TABLE sPerson.Number
(
    number VARCHAR(15) CONSTRAINT PK_number PRIMARY KEY NONCLUSTERED,
    person_ID INT CONSTRAINT FK_person_number_id FOREIGN KEY REFERENCES sPerson.Person(ID),
    isActive BIT NOT NULL DEFAULT 1,
    modified_date DATETIME DEFAULT CURRENT_TIMESTAMP
)



---------------------------------------------------

            --CREATE SCHEMA Airport

---------------------------------------------------

GO
CREATE SCHEMA sAirport
GO

CREATE TABLE sAirport.Airport
(
	IATA varchar(5) PRIMARY KEY,
    ICAO varchar(5),
    name VARCHAR(100),
    latitude_deg DECIMAL(18,16),
    longitude_deg DECIMAL(19,16),
    elevation_ft SMALLINT,
    continent VARCHAR(4),
    iso_country VARCHAR(10),
    country_name VARCHAR(100),
    iso_region VARCHAR(10),	
    region_name varchar(100),
    municipality VARCHAR(100)
)


CREATE TABLE sAirport.Airline
(
    [IATA] VARCHAR(5),
    [ICAO] VARCHAR(5),
    [Callsign] VARCHAR(50),
    [Country] VARCHAR(50),
    [Airline] VARCHAR(50),
    isActive BIT NULL DEFAULT 1,
    modified_date DATETIME DEFAULT CURRENT_TIMESTAMP
)

---------------------------------------------------

            --CREATE SCHEMA Flight

---------------------------------------------------

GO
CREATE SCHEMA sFlight
GO

CREATE TABLE sFlight.Flight(
    [FLIGHT_NUMBER] INT PRIMARY KEY,
    [YEAR] SMALLINT,
    [MONTH] SMALLINT,
    [DAY] SMALLINT,
    [DAY_OF_WEEK] SMALLINT,
    [AIRLINE] VARCHAR(5),
    [TAIL_NUMBER] VARCHAR(10),
    [ORIGIN_AIRPORT] varchar(5) FOREIGN KEY REFERENCES sAirport.Airport([IATA]),
    [DESTINATION_AIRPORT] varchar(5) FOREIGN KEY REFERENCES sAirport.Airport([IATA]),
    [SCHEDULED_DEPARTURE] varchar(6),
    [DEPARTURE_TIME] varchar(6),
    [DEPARTURE_DELAY] varchar(6),
    [TAXI_OUT] varchar(6),
    [WHEELS_OFF] varchar(6),
    [SCHEDULED_TIME] varchar(6),
    [ELAPSED_TIME] varchar(6),
    [AIR_TIME] varchar(6),
    [DISTANCE] varchar(6),
    [WHEELS_ON] varchar(6),
    [TAXI_IN] varchar(6),
    [SCHEDULED_ARRIVAL] varchar(6),
    [ARRIVAL_TIME] varchar(6),
    [ARRIVAL_DELAY] varchar(6)
)

CREATE TABLE sFlight.Flight_Emergency(
    [FLIGHT_NUMBER] INT FOREIGN KEY REFERENCES sFlight.Flight([FLIGHT_NUMBER]),
    [DIVERTED] varchar(2),
    [CANCELLED] varchar(2),
    [CANCELLATION_REASON] varchar(20),
    [AIR_SYSTEM_DELAY] varchar(9),
    [SECURITY_DELAY] varchar(9),
    [AIRLINE_DELAY] varchar(9),
    [LATE_AIRCRAFT_DELAY] varchar(9),
    [WEATHER_DELAY] varchar(9)
)


CREATE TABLE Aircraft
(
    ID INT IDENTITY CONSTRAINT PK_plane_id PRIMARY KEY,
	name VARCHAR(100),
	airline VARCHAR(5),
	operator VARCHAR(100),
	type_code VARCHAR(50),
	mode_s VARCHAR(50),
    modified_date DATETIME DEFAULT CURRENT_TIMESTAMP
)


CREATE TABLE sFlight.Ticket(
	id INT PRIMARY KEY IDENTITY,
    [FLIGHT_NUMBER] INT,-- FOREIGN KEY REFERENCES sFlight.Flight([FLIGHT_NUMBER]),
    person_ID INT CONSTRAINT FK_person_email_id FOREIGN KEY REFERENCES sPerson.Person(ID),
	seat VARCHAR(3),
	price MONEY
)


GO
CREATE VIEW vPerson 
AS 
SELECT TOP 50 [ID], [first_name], [middle_name], [last_name], [date_of_birth], [gender],[number], [modified_date] [email] 
FROM sPerson.Person P
INNER JOIN sPerson.Number N
ON N.person_ID = P.ID 
INNER JOIN sPerson.Email E
ON E.person_ID = P.ID

GO
CREATE VIEW vEmergencyFlights
AS 
SELECT TOP 50 F.[FLIGHT_NUMBER], DATEFROMPARTS(F.YEAR,F.MONTH,F.DAY) AS FLIGHT_DATE, [DAY_OF_WEEK], [AIRLINE], [TAIL_NUMBER], [ORIGIN_AIRPORT],
[DESTINATION_AIRPORT], [SCHEDULED_DEPARTURE], [DEPARTURE_TIME], [DEPARTURE_DELAY], [TAXI_OUT], [WHEELS_OFF], [SCHEDULED_TIME],
[ELAPSED_TIME], [AIR_TIME], [DISTANCE], [WHEELS_ON], [TAXI_IN], [SCHEDULED_ARRIVAL], [ARRIVAL_TIME], [ARRIVAL_DELAY],
[DIVERTED], [CANCELLED], [CANCELLATION_REASON], [AIR_SYSTEM_DELAY], [SECURITY_DELAY], [AIRLINE_DELAY], [LATE_AIRCRAFT_DELAY], [WEATHER_DELAY]
FROM sFlight.Flight F
RIGHT JOIN sFlight.Flight_Emergency E
ON E.FLIGHT_NUMBER = F.FLIGHT_NUMBER

GO
CREATE VIEW vTrip
AS SELECT TOP 50
DATEFROMPARTS(F.YEAR,F.MONTH,F.DAY) AS FLIGHT_DATE, A1.name as origin_name,
A1.country_name as origin_country , A2.name as destination_name,
A2.country_name as destination_country,
AR.Callsign as airline_name
FROM sFlight.Flight F
LEFT JOIN sAirport.Airport A1 
ON F.ORIGIN_AIRPORT= A1.ICAO
LEFT JOIN sAirport.Airport A2 
ON F.DESTINATION_AIRPORT= A2.ICAO
LEFT JOIN sAirport.Airline AR 
ON F.AIRLINE= AR.Airline

CREATE PROCEDURE 