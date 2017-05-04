CREATE TABLE [dbo].[Tablee] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [SiteName]      NVARCHAR (50) NULL,
    [UVI]           NVARCHAR (50) NULL,
    [PublishAgency] NVARCHAR (50) NULL,
    [County]        NVARCHAR (50) NULL,
    [WGS84Lon]      NVARCHAR (50) NULL,
    [WGS84Lat]      NVARCHAR (50) NULL,
    [PublishTime]   NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

