/****** Script for SelectTopNRows command from SSMS  ******/
USE [HackHunger]
GO

SELECT TOP 1 ["Input"]
      ,["Coordinates"]
  FROM AdddressesAndLatLong

SELECT  [Column 0] AS ID
		, entityname
		, ["Input"] AS SchoolAddress
		, ["Coordinates"] AS Coords
		,SUBSTRING(["Coordinates"], 
				 2, 
				 CHARINDEX(',', ["Coordinates"]) - 2) 
		AS Lat
		, SUBSTRING(["Coordinates"], 
					CHARINDEX(',', ["Coordinates"]) + 1, 
					LEN(["Coordinates"]) - CHARINDEX(',', ["Coordinates"]) - 1)
		AS Long

		
  FROM AdddressesAndLatLong AS LatTable
		JOIN [dbo].[InsitutaionAddresses] AS NameTable
			ON LatTable.["Input"] = NameTable.fulladdress
