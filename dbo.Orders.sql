CREATE TABLE [dbo].[Orders] (
    [OrderId]     INT          NOT NULL,
    [Shoe]        varCHAR (10)   NOT NULL,
    [Description] VARCHAR (15) NOT NULL,
    [Price]       MONEY NOT NULL,
    [Dispatched]   BIT          NOT NULL,
    [Firstname]        VARCHAR (15) NOT NULL,
    [Surname] VARCHAR(15) NOT NULL, 
    [Postcode] VARCHAR(7) NOT NULL, 
    PRIMARY KEY CLUSTERED ([OrderId] ASC)
);

