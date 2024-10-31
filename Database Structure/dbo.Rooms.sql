CREATE TABLE [dbo].[Rooms] (
    [roomID]    INT        NOT NULL,
    [roomFloor] INT        NULL,
    [roomType]  NCHAR (10) NULL,
    [roomCost]  NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([roomID] ASC)
);

