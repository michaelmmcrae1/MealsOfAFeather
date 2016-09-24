/****** Script for SelectTopNRows command from SSMS  ******/
USE [HackHunger]
GO

SELECT TOP 1 ["Input"]
      ,["Coordinates"]
  FROM AdddressesAndLatLong

SELECT ["Input"] AS Address
		, ["Coordinates"] AS Coords
		,SUBSTRING(["Coordinates"], 
				 2, 
				 CHARINDEX(',', ["Coordinates"]) - 2) 
		AS Lat
		, SUBSTRING(["Coordinates"], 
					CHARINDEX(',', ["Coordinates"]) + 1, 
					LEN(["Coordinates"]) - CHARINDEX(',', ["Coordinates"]) - 1)
		AS Long
  FROM AdddressesAndLatLong
