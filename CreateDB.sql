IF EXISTS 
   (
     SELECT name FROM master.dbo.sysdatabases 
    WHERE name = N'Test_C'
    )
BEGIN
    SELECT 'Database Name already Exist' AS Message
END
ELSE
BEGIN
    CREATE DATABASE [Test_C]
    SELECT 'New DB is Stored'
END

CREATE SCHEMA Test;  
GO 
	
CREATE SEQUENCE Test.st_id
  AS BIGINT
  START WITH 1
  INCREMENT BY 1
  MINVALUE 1
  MAXVALUE 99999
  NO CYCLE

create table [Test_C].[dbo].[Companies]
(id character varying(100) primary key,
name character varying (20) NOT NULL,
inn character varying (12) NOT NULL,
ur_adress character varying (30),
fac_adress character varying (30));

create table [Test_C].[dbo].[Workers]
(id character varying(100) primary key,
MidName character varying (20) NOT NULL,
FirstName character varying (12) NOT NULL,
LastName character varying (30),
BirthDate Date,
PasSer character varying (30),
PasNumber character varying (30));

BULK INSERT [Test_C].[dbo].[Workers]
FROM '$(FullScriptDir)\test.csv'
WITH (fieldterminator = ',', rowterminator = '\n');