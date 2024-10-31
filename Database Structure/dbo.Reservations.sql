CREATE TABLE [dbo].[Reservations] (
    [reserveID]     INT      IDENTITY (1, 1) NOT NULL,
    [reserveUserID] INT      NOT NULL,
    [reserveRoomID] INT      NOT NULL,
    [startDate]     DATETIME NULL,
    [endDate]       DATETIME NULL,
    PRIMARY KEY CLUSTERED ([reserveID] ASC),
    FOREIGN KEY ([reserveRoomID]) REFERENCES [dbo].[Rooms] ([roomID]),
    FOREIGN KEY ([reserveUserID]) REFERENCES [dbo].[Users] ([userID])
);

