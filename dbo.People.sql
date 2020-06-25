USE [PhoneBook]
GO

/****** Object: Table [dbo].[People] Script Date: 2020-06-24 23:33:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[People] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (255) NULL,
    [LastName]     NVARCHAR (255) NOT NULL,
    [Phone]        INT            NOT NULL,
    [Email]        NVARCHAR (255) NULL,
    [CreationDate] DATETIME       NULL,
    [UpdateDate]   DATETIME       NULL
);


