CREATE TABLE [dbo].[Firearms] (
    --[FAId]    INT          IDENTITY (1, 1) NOT NULL,
	[Serial]  VARCHAR (40) NOT NULL,
    [Brand]   VARCHAR (20) NULL,
    [Model]   VARCHAR (20) NULL,
    [Caliber] INT          NULL,
    PRIMARY KEY CLUSTERED ([Serial] ASC),
    FOREIGN KEY ([Caliber]) REFERENCES [dbo].[Calibers] ([CalId])
);