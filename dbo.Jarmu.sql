CREATE TABLE [dbo].[Jarmu]	
(
	[Azonosito] NCHAR(8) NOT NULL PRIMARY KEY, 
    [GyartoNev] NVARCHAR(MAX) NOT NULL, 
    [FutottKm] INT NOT NULL, 
    [AjtokSzama] INT NOT NULL, 
    [FerohelyekSzama] INT NOT NULL
)
