CREATE TABLE [dbo].[Entry] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [name]        VARCHAR (MAX) NULL,
    [description] VARCHAR (MAX) NULL,
    [fileLink]    VARCHAR (MAX) NULL,
    [score]       FLOAT (53)    DEFAULT ((0)) NOT NULL,
    [rank]        INT           DEFAULT ((0)) NOT NULL,
    [votes]       INT           DEFAULT ((0)) NOT NULL,
    [ComId]       INT           NOT NULL,
    [UserId]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Entry_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id]),
    CONSTRAINT [FK_Entry_Competition] FOREIGN KEY ([ComId]) REFERENCES [dbo].[Competition] ([Id])
);

CREATE TABLE [dbo].[Competition] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [name]        VARCHAR (MAX) NOT NULL,
    [description] VARCHAR (MAX) NOT NULL,
    [judges]      CHAR (50)     NULL,
    [winners]     CHAR (50)     NULL,
    [startDate]   DATETIME      NOT NULL,
    [endDate]     DATETIME      NOT NULL,
	[isDeleted]	  BIT		DEFAULT((0)) NOT NULL, 
    [entriesNo]   INT           DEFAULT ((0)) NOT NULL,
    [UserId]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Competition_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

CREATE TABLE [dbo].[User] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [username]   VARCHAR (50)    NOT NULL,
    [email]      VARCHAR (50)    NOT NULL,
    [password]   VARCHAR (256)   NOT NULL,
    [country]    VARCHAR (50)    NULL,
    [profilePic] VARBINARY (MAX) NULL,
    [isAdmin]    BIT             DEFAULT ((0)) NOT NULL,
    [isBusiness] BIT             DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


