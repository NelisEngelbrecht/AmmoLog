CREATE TABLE [dbo].[Ammo] (
    [AmmoId]  INT          IDENTITY (1, 1) NOT NULL,
    [Brand]   VARCHAR (40) NULL,
    [Caliber] INT          NULL,
    [Weight]  INT          NULL,
    [Style]   VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([AmmoId] ASC),
    FOREIGN KEY ([Caliber]) REFERENCES [dbo].[Calibers] ([CalId])
);

