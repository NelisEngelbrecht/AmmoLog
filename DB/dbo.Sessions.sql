CREATE TABLE [dbo].[Sessions] (
    [SessionId]  INT          IDENTITY (1, 1) NOT NULL,
    [Date]       VARCHAR (40) NULL,
    [Firearm]    VARCHAR (40) NOT NULL,
    [RangeName]  VARCHAR (40) NULL,
    [Ammo]       INT          NULL,
    [RoundCount] VARCHAR (40) NULL,
    [Failures]   INT          NULL,
    [GroupSize]  VARCHAR (40) NULL,
    [Distance]   VARCHAR (40) NULL,
    PRIMARY KEY CLUSTERED ([SessionId] ASC),
    FOREIGN KEY ([Ammo]) REFERENCES [dbo].[Ammo] ([AmmoId]),
	FOREIGN KEY ([Firearm]) REFERENCES [dbo].[Firearms] ([Serial])
);

