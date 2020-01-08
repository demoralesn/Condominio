CREATE TABLE [dbo].[reserva] (
    [id]        INT         IDENTITY (1, 1) NOT NULL,
    [propiedad] VARCHAR (5) NULL,
    [fecha]     DATETIME    NULL,
    CONSTRAINT [PK_reserva] PRIMARY KEY CLUSTERED ([id] ASC)
);