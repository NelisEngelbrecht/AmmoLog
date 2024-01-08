CREATE TABLE [dbo].[Sessions] (
    [SessionId]  INT          IDENTITY (1, 1) NOT NULL,
    [Date]       VARCHAR (40) NULL,
    [Firearm]    VARCHAR (40) NOT NULL,
    [RangeName]  VARCHAR (40) NULL,
    [Ammo]       VARCHAR (40) NULL,
    [RoundCount] FLOAT (53)   NULL,
    [Failures]   FLOAT (53)   NULL,
    [GroupSize]  INT          NULL,
    [Distance]   VARCHAR (40) NULL,
    PRIMARY KEY CLUSTERED ([SessionId] ASC),
    FOREIGN KEY ([Firearm]) REFERENCES [dbo].[Firearms] ([Serial]),
    FOREIGN KEY ([Ammo]) REFERENCES [dbo].[Ammo] ([AmmoId])
);

