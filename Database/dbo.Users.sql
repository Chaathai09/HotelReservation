CREATE TABLE [dbo].[Users] (
    [userID]            INT          NOT NULL IDENTITY,
    [username]          VARCHAR (50) NULL,
    [password]          VARCHAR (50) NULL,
    [isAdmin]              BIT          NULL,
    [name]              NVARCHAR(50) NULL,
    [surname]           NVARCHAR(50) NULL,
    [email]             VARCHAR (50) NULL,
    [phone]             VARCHAR (15) NULL,
    [identification_no] VARCHAR (13) NULL,
    [address]           NTEXT         NULL,
    PRIMARY KEY CLUSTERED ([userID] ASC)
);

