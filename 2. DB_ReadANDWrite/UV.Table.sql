CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SiteName] NCHAR(10) NULL, 
    [UVI] NCHAR(10) NULL, 
    [PublishAgency] NCHAR(10) NULL, 
    [County] NCHAR(10) NULL, 
    [WGS84Lon] NCHAR(10) NULL, 
    [WGS84Lat] NCHAR(10) NULL, 
    [PublishTime] NCHAR(10) NULL
)
