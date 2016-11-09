CREATE TABLE [dbo].[Jarmu]	
(
	[Azonosito] NCHAR(8) NOT NULL PRIMARY KEY, 
    [GyartoNev] NVARCHAR(MAX) NOT NULL, 
    [FutottKm] INT NOT NULL, 
    [AjtokSzama] INT NOT NULL, 
    [FerohelyekSzama] INT NOT NULL
);

CREATE TABLE [dbo].[Kotottpalyas]
(
	[Azonosito] NCHAR(8) NOT NULL PRIMARY KEY, 
    [Sinszelesseg] INT NOT NULL, 
    [Aramellatas] TINYINT NOT NULL, 

);

CREATE TABLE [dbo].[Metro]
(
	[Azonosito] NCHAR(8) NOT NULL PRIMARY KEY, 
    [Szerelveny] INT NULL, 
);

CREATE TABLE [dbo].[Villamos]
(
	[Azonosito] NCHAR(8) NOT NULL PRIMARY KEY, 
    [EgybeNyitott] BIT NOT NULL, 
);

CREATE TABLE [dbo].[Busz]
(
	[Azonosito] NCHAR(8) NOT NULL PRIMARY KEY, 
    [TankUrtartalom] INT NOT NULL, 
    [Hibrid] BIT NOT NULL, 
    [Csuklos] BIT NOT NULL, 
);
