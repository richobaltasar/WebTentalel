﻿CREATE TABLE [dbo].[Master_Form] (
    [idLog]      BIGINT         IDENTITY (1, 1) NOT NULL,
    [NamaForm]   NVARCHAR (MAX) NOT NULL,
    [Type]       NVARCHAR (MAX) NULL,
    [Id]         NVARCHAR (MAX) NULL,
    [TextLabel]  NVARCHAR (MAX) NULL,
    [Action]     NVARCHAR (MAX) NULL,
    [Controller] NVARCHAR (MAX) NULL,
    [ValueInput] NVARCHAR (MAX) NULL,
    [ListModel]  NVARCHAR (MAX) NULL,
    [Urutan]     INT            NULL,
    [ShowHide]   NVARCHAR (MAX) NULL,
    [ReadOnly]   NVARCHAR (MAX) NULL,
    [Enable]     NVARCHAR (MAX) NULL,
    [Mandatory]  NVARCHAR (MAX) NULL,
    [IsNumber]   INT            NULL,
    CONSTRAINT [PK_Master_Form] PRIMARY KEY CLUSTERED ([idLog] ASC)
);

