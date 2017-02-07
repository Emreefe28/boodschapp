
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/07/2017 21:01:27
-- Generated from EDMX file: C:\Users\Emre-PC\Documents\Visual Studio 2013\Projects\ASP\Boodschapp\Boodschapp\BoodschappModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Boodschapp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserAankoop]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aankoops] DROP CONSTRAINT [FK_UserAankoop];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Aankoops]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aankoops];
GO
IF OBJECT_ID(N'[dbo].[Paids1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Paids1];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [id] int IDENTITY(1,1) NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [bank_nr] nvarchar(max)  NOT NULL,
    [created_at] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Aankoops'
CREATE TABLE [dbo].[Aankoops] (
    [id] int IDENTITY(1,1) NOT NULL,
    [User_id] int  NOT NULL,
    [product_name] nvarchar(max)  NOT NULL,
    [price] nvarchar(max)  NOT NULL,
    [created_at] nvarchar(max)  NOT NULL,
    [updated_at] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Paids1'
CREATE TABLE [dbo].[Paids1] (
    [id] int IDENTITY(1,1) NOT NULL,
    [user_id_sender] nvarchar(max)  NOT NULL,
    [user_id_receiver] nvarchar(max)  NOT NULL,
    [amount] nvarchar(max)  NOT NULL,
    [created_at] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Aankoops'
ALTER TABLE [dbo].[Aankoops]
ADD CONSTRAINT [PK_Aankoops]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Paids1'
ALTER TABLE [dbo].[Paids1]
ADD CONSTRAINT [PK_Paids1]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [User_id] in table 'Aankoops'
ALTER TABLE [dbo].[Aankoops]
ADD CONSTRAINT [FK_UserAankoop]
    FOREIGN KEY ([User_id])
    REFERENCES [dbo].[Users]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserAankoop'
CREATE INDEX [IX_FK_UserAankoop]
ON [dbo].[Aankoops]
    ([User_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------