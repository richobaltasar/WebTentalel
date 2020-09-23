CREATE TABLE [dbo].[DataServices_LandingPage] (
    [Id]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (MAX) NULL,
    [Icon]        NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Action]      NVARCHAR (MAX) NULL,
    [Controller]  NVARCHAR (MAX) NULL
);

