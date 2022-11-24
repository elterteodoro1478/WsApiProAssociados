USE [PVProauto]
GO
/****** Object:  Table [dbo].[Associado]    Script Date: 24/11/2022 20:40:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Associado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[CPF] [varchar](14) NULL,
	[Placa] [varchar](10) NOT NULL,
	[TelefoneFixo] [varchar](20) NULL,
	[TelefoneCeluar] [varchar](20) NULL,
	[CEP] [varchar](10) NULL,
	[Logradouro] [varchar](100) NOT NULL,
	[Numero] [varchar](10) NOT NULL,
	[Complemento] [varchar](50) NULL,
	[Bairro] [varchar](100) NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[UF] [varchar](2) NOT NULL,
	[UsuarioMaster] [bit] NOT NULL,
 CONSTRAINT [PK_Associado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH ( ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Associado] ON 
GO
INSERT [dbo].[Associado] ([Id], [Nome], [CPF], [Placa], [TelefoneFixo], [TelefoneCeluar], [CEP], [Logradouro], [Numero], [Complemento], [Bairro], [Cidade], [UF], [UsuarioMaster]) VALUES (3, N'Matriz', N'111222.33344', N'ABC1234', N'3140303399', N'31940303399', N'31310350', N'Rua Adma Sabá Paiva', N'189', NULL, N'Ouro Preto ', N'Belo Horizonte', N'MG', 1)
GO
INSERT [dbo].[Associado] ([Id], [Nome], [CPF], [Placa], [TelefoneFixo], [TelefoneCeluar], [CEP], [Logradouro], [Numero], [Complemento], [Bairro], [Cidade], [UF], [UsuarioMaster]) VALUES (4, N'Florenço Trindade Alburquerque', N'56704296050', N'GTX1650', N'331556', N'331556', N'311560325', N'Raul Soares', N'1237', N'apto 10', N'Centro', N'Betim', N'CE', 0)
GO
INSERT [dbo].[Associado] ([Id], [Nome], [CPF], [Placa], [TelefoneFixo], [TelefoneCeluar], [CEP], [Logradouro], [Numero], [Complemento], [Bairro], [Cidade], [UF], [UsuarioMaster]) VALUES (5, N'Maria Cristina Silveira', N'20937653063', N'KMS4891', N'', N'', N'31250200', N'Rua Bom Jardim', N'1930', N' apto 1702 bloc 04', N'Ermelinda', N'Belo Horizonte', N'MG', 0)
GO
INSERT [dbo].[Associado] ([Id], [Nome], [CPF], [Placa], [TelefoneFixo], [TelefoneCeluar], [CEP], [Logradouro], [Numero], [Complemento], [Bairro], [Cidade], [UF], [UsuarioMaster]) VALUES (6, N'Geraldo Magela Guerra', N'33942569086', N'QTR1128', N'', N'', N'31250200', N'Rua Bom Jardim', N'1930', N' apto 1702 bloc 04', N'Ermelinda', N'Belo Horizonte', N'MG', 0)
GO
INSERT [dbo].[Associado] ([Id], [Nome], [CPF], [Placa], [TelefoneFixo], [TelefoneCeluar], [CEP], [Logradouro], [Numero], [Complemento], [Bairro], [Cidade], [UF], [UsuarioMaster]) VALUES (7, N'Celso Futrado Silva', N'04394372020', N'GBW5348', N'', N'', N'31250200', N'Rua Bom Jardim', N'1930', N' apto 1702 bloc 04', N'Ermelinda', N'Belo Horizonte', N'MG', 0)
GO
INSERT [dbo].[Associado] ([Id], [Nome], [CPF], [Placa], [TelefoneFixo], [TelefoneCeluar], [CEP], [Logradouro], [Numero], [Complemento], [Bairro], [Cidade], [UF], [UsuarioMaster]) VALUES (8, N'Roberto Barbosa', N'57860148005', N'MJH3090', N'', N'', N'31250200', N'Rua Bom Jardim', N'1930', N' apto 1702 bloc 04', N'Ermelinda', N'Belo Horizonte', N'MG', 0)
GO
INSERT [dbo].[Associado] ([Id], [Nome], [CPF], [Placa], [TelefoneFixo], [TelefoneCeluar], [CEP], [Logradouro], [Numero], [Complemento], [Bairro], [Cidade], [UF], [UsuarioMaster]) VALUES (9, N'José Antônio Gama', N'39875497002', N'AFA9910', N'', N'', N'01408001', N'Alameda Casa Branca', N'3136', N' apto 168 ', N'Jardim Paulista', N'São Paulo', N'SP', 0)
GO
SET IDENTITY_INSERT [dbo].[Associado] OFF
GO
