CREATE TABLE [dbo].[Busz]
(
	[Azonosito] NCHAR(8) NOT NULL PRIMARY KEY, 
    [TankUrtartalom] INT NOT NULL, 
    [Hibrid] BIT NOT NULL, 
    [Csuklos] BIT NOT NULL, 
)
