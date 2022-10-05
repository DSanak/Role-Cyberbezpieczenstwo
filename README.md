# Role-Cyberbezpieczenstwo

Baza:

CREATE TABLE [dbo].[tb_loginrole] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [name]     NVARCHAR (50) NULL,
    [username] NVARCHAR (50) NULL,
    [password] NVARCHAR (50) NULL,
    [type]     NVARCHAR (50) NULL,
    [isBlock]  NVARCHAR (3)  DEFAULT ('No') NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

Wklejasz to w SQL a potem w connection stringu (var connection) podmieniasz Users na Nazwę bazy do ktorej tą tabele dodajesz i dziala
