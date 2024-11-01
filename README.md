# LinkedTech
Projeto de avaliação para Linked-Tech

Sistema desenvolvido com as praticas do Clean Arquiteture com as Camadas 1 - API(EndPoints) 2 - Application(Contato do externo com Interno, criando assim segurança) 3 - Domain(Core do projeto, bem como dominio e base para repositorios) 4 - Domain.Test( Implementacao de XUnit para cobertura de codigo e teste unitarios) 5 - Infra.Data (Camada de acesso ao banco de dados) 6 - Infra.Data.IoC( Injeção de dependencia) 7 - WebUI (Camada Front-end)

banco de dados criado uma tabela foi gerado com a connection string na qual deve ser mduada e direcionada com o banco local (O mesmo fica localizado na Camada 6 (Infra.Data.Ioc)
connectionString = @"Data Source=DESKTOP-OAG94LR\SQLEXPRESS;Initial Catalog=AVALIACAO;Integrated Security=True;";

Foram feitas os testes unitarios para os metodos selecionados. A cobertura está tanto para Controller quanto para a camada Application e Repository

OBS: O projeto deve ser STARTADO DE FORMA MULTIPLA API E WEBUI.

SEGUE SCRIPT DE BANCO DE DADOS :

USE [AVALIACAO]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 01/11/2024 14:55:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cpf] [varchar](11) NOT NULL,
	[DataNascimento] [datetime] NOT NULL,
	[UfNascimento] [varchar](2) NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Endereco](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[Logradouro] [varchar](500) NOT NULL,
	[Bairro] [varchar](100) NOT NULL,
	[Cidade] [varchar](100) NOT NULL,
	[Uf] [varchar](2) NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [FK_Endereco_Cliente] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Cliente] ([Id])
GO

ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [FK_Endereco_Cliente]
GO
