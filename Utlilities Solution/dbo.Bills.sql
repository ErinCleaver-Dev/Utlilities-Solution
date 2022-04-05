CREATE TABLE [dbo].[Bills] (
    [Month]       INT            IDENTITY (1, 1) NOT NULL,
    [Electricity] DECIMAL (5, 2) NOT NULL,
    [WATER]       DECIMAL (5, 2) NOT NULL,
    [GAS]         DECIMAL (5, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Month] ASC)
);

