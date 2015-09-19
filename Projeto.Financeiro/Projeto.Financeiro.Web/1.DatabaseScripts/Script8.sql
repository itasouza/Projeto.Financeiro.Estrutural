/*
Created		24/08/2015
Modified		17/09/2015
Project		Sis Caoxa
Model			Modelo Principal
Company		Itasouza
Author		Itamar Souza
Version		01
Database		MS SQL 2000 
*/


















Create table [TB_EMPRESA]
(
	[IDEMPRESA] Integer NOT NULL, UNIQUE ([IDEMPRESA]),
	[RAZAO_SOCIAL] Varchar(150) NULL,
	[ENDERECO] Varchar(150) NULL,
	[BAIRRO] Varchar(50) NULL,
	[CIDADE] Varchar(50) NULL,
	[IMAGEM_LOGO] Varchar(100) NULL,
	[STATUS] Char(1) Default 'N' NULL,
	[MARCA] Char(1) Default 'N' NULL,
	[DATA_INC] Datetime NULL,
	[DATA_HAB] Datetime NULL,
	[DATA_ALT] Datetime NULL,
Primary Key ([IDEMPRESA])
) 
go

Create table [TB_CLIENTE_FORNECEDOR]
(
	[IDCLIENTEFORNECEDOR] Integer NOT NULL, UNIQUE ([IDCLIENTEFORNECEDOR]),
	[CODIGO] Char(10) NULL,
	[TIPO] Char(1) NULL,
	[RAZAO_SOCIAL] Varchar(150) NULL,
	[ENDERECO] Varchar(100) NULL,
	[NUMERO] Char(10) NULL,
	[COMPLEMENTO] Varchar(100) NULL,
	[BAIRRO] Varchar(50) NULL,
	[TELEFONE] Varchar(10) NULL,
	[CELULAR] Varchar(10) NULL,
	[CIDADE] Varchar(50) NULL,
	[UF] Char(2) NULL,
	[CEP] Char(10) NULL,
	[CNPJ] Char(20) NULL,
	[NOME_ADMINISTRADOR] Varchar(150) NULL,
	[DATA_NASCIMENTO] Datetime NULL,
	[EMAIL] Varchar(50) NULL,
	[MSN] Varchar(50) NULL,
	[SKYPE] Varchar(50) NULL,
	[HOME_PAGE] Varchar(50) NULL,
	[IDEMPRESA] Integer NOT NULL,
	[IDUSUARIO] Integer NOT NULL,
	[CONTADOR_ESCRITORIO] Varchar(200) NULL,
	[CONTADOR_NOME] Varchar(10) NULL,
	[CONTADOR_TELEFONE] Varchar(10) NULL,
	[CONTADOR_CELULAR] Varchar(10) NULL,
	[CONTADOR_EMAIL] Varchar(50) NULL,
	[DESPACHANTE_NOME] Varchar(200) NULL,
	[DESPACHANTE_TELEFONE] Varchar(10) NULL,
	[DESPACHANTE_CELULAR] Varchar(10) NULL,
	[DESPACHANTE_EMAIL] Varchar(50) NULL,
	[STATUS] Char(1) Default 'N' NULL,
	[MARCA] Char(1) Default 'N' NULL,
	[DATA_INC] Datetime NULL,
	[DATA_HAB] Datetime NULL,
	[DATA_ALT] Datetime NULL,
Primary Key ([IDCLIENTEFORNECEDOR])
) 
go

Create table [TB_PLANO_CONTAS]
(
	[IDPLANOCONTAS] Integer NOT NULL, UNIQUE ([IDPLANOCONTAS]),
	[NUMERO_CONTA] Char(10) NULL,
	[DESCRICAO_CONTA] Varchar(50) NULL,
	[OPERACAO] Char(1) NULL,
	[IDUSUARIO] Integer NOT NULL,
	[STATUS] Char(1) Default 'N' NULL,
	[MARCA] Char(1) Default 'N' NULL,
	[DATA_INC] Datetime NULL,
	[DATA_HAB] Datetime NULL,
	[DATA_ALT] Datetime NULL,
	[IDEMPRESA] Integer NOT NULL,
Primary Key ([IDPLANOCONTAS])
) 
go

Create table [TB_BANCO]
(
	[IDBANCO] Integer NOT NULL, UNIQUE ([IDBANCO]),
	[NOME_GERENTE] Varchar(100) NULL,
	[TELEFONE] Char(10) NULL,
	[CELULAR] Char(10) NULL,
	[IDEMPRESA] Integer NOT NULL,
	[IDUSUARIO] Integer NOT NULL,
	[BOLETO_CHAVECONTA] Varchar(20) NULL,
	[BOLETO_BANCO] Char(10) NULL,
	[BOLETO_AGENCIA] Char(10) NULL,
	[BOLETO_CONTA] Char(10) NULL,
	[BOLETO_CODIGO] Char(10) NULL,
	[BOLETO_NOMECEDENTE] Varchar(150) NULL,
	[BOLETO_CPFCNPJ] Char(20) NULL,
	[BOLETO_INICIONOSSONUMERO] Char(20) NULL,
	[BOLETO_FIMNOSSONUMERO] Char(20) NULL,
	[BOLETO_PROXIMONUMERO] Char(20) NULL,
	[BOLETO_ARQUIVOLICENCA] Char(20) NULL,
	[BOLETO_EMAILCEDENTE] Char(20) NULL,
	[BOLETO_CAMINHOLOGOTIPO] Varchar(50) NULL,
	[BOLETO_IDENTIFICACAO] Char(20) NULL,
	[STATUS] Char(1) Default 'N' NULL,
	[MARCA] Char(1) Default 'N' NULL,
	[DATA_INC] Datetime NULL,
	[DATA_HAB] Datetime NULL,
	[DATA_ALT] Datetime NULL,
Primary Key ([IDBANCO])
) 
go

Create table [TB_CONTAS_RECEBER]
(
	[IDCONTASRECEBER] Integer NOT NULL, UNIQUE ([IDCONTASRECEBER]),
	[IDCLIENTEFORNECEDOR] Integer NOT NULL,
	[IDEMPRESA] Integer NOT NULL,
	[IDPLANOCONTAS] Integer NOT NULL,
	[IDBANCO] Integer NOT NULL,
	[IDPRODUTO] Integer NOT NULL,
	[IDUSUARIO] Integer NOT NULL,
	[DESCRICAO] Varchar(150) NULL,
	[SITUACAO_TITULO] Char(1) NULL,
	[VALOR_TITULO] Numeric(10,2) NULL,
	[VALOR_RECEBIDO] Numeric(10,2) NULL,
	[VALOR_RESTANTE] Numeric(10,2) NULL,
	[JUROS] Numeric(10,2) NULL,
	[MORA] Numeric(10,2) NULL,
	[DATA_VENCIMENTO] Datetime NULL,
	[DATA_BAIXA] Datetime NULL,
	[NUMERO_DOCUMENTO] Char(20) NULL,
	[OBSERVACAO] Text NULL,
	[STATUS] Char(1) Default 'N' NULL,
	[MARCA] Char(1) Default 'N' NULL,
	[DATA_INC] Datetime NULL,
	[DATA_HAB] Datetime NULL,
	[DATA_ALT] Datetime NULL,
Primary Key ([IDCONTASRECEBER])
) 
go

Create table [TB_USUARIO]
(
	[IDUSUARIO] Integer NOT NULL, UNIQUE ([IDUSUARIO]),
	[IDEMPRESA] Integer NOT NULL,
	[NOME_USUARIO] Varchar(150) NULL,
	[TELEFONE] Char(10) NULL,
	[EMAIL] Varchar(100) NULL,
	[CELULAR] Char(10) NULL,
	[VENDEDOR] Char(1) Default 'N' NULL,
	[PARCEIRO] Char(1) Default 'N' NULL,
	[JURIDICO] Char(1) Default 'N' NULL,
	[SENHA] Char(20) NULL,
	[LOGIN] Char(20) NULL,
	[IDPERFIL] Integer NOT NULL,
	[ENDERECO] Varchar(200) NULL,
	[NUMERO] Char(10) NULL,
	[COMPLEMENTO] Varchar(200) NULL,
	[BAIRRO] Varchar(50) NULL,
	[CIDADE] Varchar(20) NULL,
	[CEP] Varchar(10) NULL,
	[CNPJ] Varchar(25) NULL,
	[CPF] Varchar(25) NULL,
	[STATUS] Char(1) Default 'N' NULL,
	[MARCA] Char(1) Default 'N' NULL,
	[DATA_INC] Datetime NULL,
	[DATA_HAB] Datetime NULL,
	[DATA_ALT] Datetime NULL,
Primary Key ([IDUSUARIO])
) 
go

Create table [TB_PERFIL]
(
	[IDPERFIL] Integer NOT NULL, UNIQUE ([IDPERFIL]),
	[DESCRICAO_PERFIL] Varchar(200) NULL,
	[PERFIL] Char(1) Default 'N' NULL,
	[EMPRESA] Char(1) Default 'N' NULL,
	[EMPRESA_I] Char(1) Default 'N' NULL,
	[EMPRESA_A] Char(1) Default 'N' NULL,
	[EMPRESA_E] Char(1) Default 'N' NULL,
	[EMPRESA_NAVEGA] Char(1) Default 'N' NULL,
	[CLIENTE] Char(1) Default 'N' NULL,
	[CLIENTE_I] Char(1) Default 'N' NULL,
	[CLIENTE_A] Char(1) Default 'N' NULL,
	[CLIENTE_E] Char(1) Default 'N' NULL,
	[CLIENTE_NAVEGA] Char(1) Default 'N' NULL,
	[PLANOCONTAS] Char(1) Default 'N' NULL,
	[PLANOCONTAS_I] Char(1) Default 'N' NULL,
	[PLANOCONTAS_A] Char(1) Default 'N' NULL,
	[PLANOCONTAS_E] Char(1) Default 'N' NULL,
	[PLANOCONTAS_NAVEGA] Char(1) Default 'N' NULL,
	[USUARIO] Char(1) Default 'N' NULL,
	[USUARIO_I] Char(1) Default 'N' NULL,
	[USUARIO_A] Char(1) Default 'N' NULL,
	[USUARIO_E] Char(1) Default 'N' NULL,
	[USUARIO_NAVEGA] Char(1) Default 'N' NULL,
	[BANCO] Char(1) Default 'N' NULL,
	[BANCO_I] Char(1) Default 'N' NULL,
	[BANCO_A] Char(1) Default 'N' NULL,
	[BANCO_E] Char(1) Default 'N' NULL,
	[BANCO_NAVEGA] Char(1) Default 'N' NULL,
	[CONTASPAGAR] Char(1) Default 'N' NULL,
	[CONTASPAGAR_I] Char(1) Default 'N' NULL,
	[CONTASPAGAR_A] Char(1) Default 'N' NULL,
	[CONTASPAGAR_E] Char(1) Default 'N' NULL,
	[CONTASPAGAR_NAVEGA] Char(1) Default 'N' NULL,
	[CONTASRECEBER] Char(1) NULL,
	[CONTASRECEBER_I] Char(1) NULL,
	[CONTASRECEBER_A] Char(1) NULL,
	[CONTASRECEBER_E] Char(1) NULL,
	[CONTASRECEBER_NAVEGA] Char(1) NULL,
	[RECIBO] Char(1) Default 'N' NULL,
	[RECIBO_I] Char(1) Default 'N' NULL,
	[RECIBO_A] Char(1) Default 'N' NULL,
	[RECIBO_E] Char(1) Default 'N' NULL,
	[RECIBO_NAVEGA] Char(1) Default 'N' NULL,
	[BOLETO] Char(1) Default 'N' NULL,
	[BOLETO_I] Char(1) Default 'N' NULL,
	[BOLETO_A] Char(1) Default 'N' NULL,
	[BOLETO_E] Char(1) Default 'N' NULL,
	[BOLETO_NAVEGA] Char(1) Default 'N' NULL,
	[PRODUTO_SERVICO] Char(1) NULL,
	[PRODUTO_SERVICO_I] Char(1) Default 'N' NULL,
	[PRODUTO_SERVICO_A] Char(1) Default 'N' NULL,
	[PRODUTO_SERVICO_E] Char(1) Default 'N' NULL,
	[PRODUTO_SERVICO_NAVEGA] Char(1) Default 'N' NULL,
	[STATUS] Char(1) Default 'N' NULL,
	[MARCA] Char(1) Default 'N' NULL,
	[DATA_INC] Datetime NULL,
	[DATA_HAB] Datetime NULL,
	[DATA_ALT] Datetime NULL,
	[IDEMPRESA] Integer NOT NULL,
Primary Key ([IDPERFIL])
) 
go

Create table [TB_RECIBO]
(
	[IDRECIBO] Integer NOT NULL, UNIQUE ([IDRECIBO]),
	[IDCLIENTEFORNECEDOR] Integer NOT NULL,
	[VALOR_RECIBO] Numeric(10,2) NULL,
	[VALOR_EXTENSO] Varchar(100) NULL,
	[OBSERVACAO] Text NULL,
	[CIDADE] Varchar(50) NULL,
	[DATA_RECIBO] Datetime NULL,
	[STATUS] Char(1) Default 'N' NULL,
	[MARCA] Char(1) Default 'N' NULL,
	[DATA_INC] Datetime NULL,
	[DATA_HAB] Datetime NULL,
	[DATA_ALT] Datetime NULL,
	[IDEMPRESA] Integer NOT NULL,
	[IDUSUARIO] Integer NOT NULL,
Primary Key ([IDRECIBO])
) 
go

Create table [TB_BOLETO_EMITIDO]
(
	[IDBOLETO] Integer NOT NULL, UNIQUE ([IDBOLETO]),
	[IDCLIENTEFORNECEDOR] Integer NOT NULL,
	[DATA_VENCIMENTO] Datetime NULL,
	[VALOR_BOLETO] Numeric(10,2) NULL,
	[PERCENTUAL_JUROS] Numeric(10,2) NULL,
	[PERCENTUAL_MULTA] Numeric(10,2) NULL,
	[PERCENTUAL_DESCONTO] Numeric(10,2) NULL,
	[OUTROS_ACRESCIMOS] Numeric(10,2) NULL,
	[DEMONSTRATIVO] Varchar(30) NULL,
	[INSTRUCOES_CAIXA] Varchar(30) NULL,
	[NOSSO_NUMERO] Char(10) NULL,
	[DATA_PAGAMENTO] Datetime NULL,
	[VALOR_PAGO] Numeric(10,2) NULL,
	[STATUS] Char(1) Default 'N' NULL,
	[MARCA] Char(1) Default 'N' NULL,
	[DATA_INC] Datetime NULL,
	[DATA_HAB] Datetime NULL,
	[DATA_ALT] Datetime NULL,
	[IDEMPRESA] Integer NOT NULL,
	[IDUSUARIO] Integer NOT NULL,
Primary Key ([IDBOLETO])
) 
go

Create table [TB_PRODUTO_SERVICO]
(
	[IDPRODUTO] Integer NOT NULL,
	[DESCRICAO] Varchar(200) NULL,
	[STATUS] Char(1) Default 'N' NULL,
	[MARCA] Char(1) Default 'N' NULL,
	[DATA_INC] Datetime NULL,
	[DATA_HAB] Datetime NULL,
	[DATA_ALT] Datetime NULL,
	[IDEMPRESA] Integer NOT NULL,
	[IDUSUARIO] Integer NOT NULL,
Primary Key ([IDPRODUTO])
) 
go

Create table [TB_CLIENTE_SERVICO]
(
	[IDCLIENTESERVICO] Integer NOT NULL,
	[IDCLIENTEFORNECEDOR] Integer NOT NULL,
	[IDPRODUTO] Integer NOT NULL,
	[COMISSAO_SERVICO] Numeric(10,2) NULL,
	[DATA_DO_CONTRATO] Datetime NULL,
	[IDPARCEIRO] Integer NULL,
	[COMISSAO_PARCEIRO] Numeric(10,2) NULL,
	[IDVENDEDOR] Integer NULL,
	[COMISSAO_VENDEDOR] Numeric(10,2) NULL,
	[IDADVOGADO] Integer NULL,
	[COMISSAO_ADVOGADO] Numeric(10,2) NULL,
Primary Key ([IDCLIENTESERVICO])
) 
go

Create table [TB_CONTAS_PAGAR]
(
	[IDCONTASPAGAR] Integer NOT NULL, UNIQUE ([IDCONTASPAGAR]),
	[IDCLIENTEFORNECEDOR] Integer NOT NULL,
	[IDEMPRESA] Integer NOT NULL,
	[IDPLANOCONTAS] Integer NOT NULL,
	[IDBANCO] Integer NOT NULL,
	[IDUSUARIO] Integer NOT NULL,
	[DESCRICAO] Varchar(150) NULL,
	[SITUACAO_TITULO] Char(1) NULL,
	[VALOR_TITULO] Numeric(10,2) NULL,
	[VALOR_RECEBIDO] Numeric(10,2) NULL,
	[VALOR_RESTANTE] Numeric(10,2) NULL,
	[JUROS] Numeric(10,2) NULL,
	[MORA] Numeric(10,2) NULL,
	[DATA_VENCIMENTO] Datetime NULL,
	[DATA_BAIXA] Datetime NULL,
	[NUMERO_DOCUMENTO] Char(20) NULL,
	[OBSERVACAO] Text NULL,
	[STATUS] Char(1) Default 'N' NULL,
	[MARCA] Char(1) Default 'N' NULL,
	[DATA_INC] Datetime NULL,
	[DATA_HAB] Datetime NULL,
	[DATA_ALT] Datetime NULL,
Primary Key ([IDCONTASPAGAR])
) 
go








Alter table [TB_CLIENTE_FORNECEDOR] add  foreign key([IDEMPRESA]) references [TB_EMPRESA] ([IDEMPRESA])  on update no action on delete no action 
go
Alter table [TB_CONTAS_RECEBER] add  foreign key([IDEMPRESA]) references [TB_EMPRESA] ([IDEMPRESA])  on update no action on delete no action 
go
Alter table [TB_BANCO] add  foreign key([IDEMPRESA]) references [TB_EMPRESA] ([IDEMPRESA])  on update no action on delete no action 
go
Alter table [TB_USUARIO] add  foreign key([IDEMPRESA]) references [TB_EMPRESA] ([IDEMPRESA])  on update no action on delete no action 
go
Alter table [TB_PLANO_CONTAS] add  foreign key([IDEMPRESA]) references [TB_EMPRESA] ([IDEMPRESA])  on update no action on delete no action 
go
Alter table [TB_PRODUTO_SERVICO] add  foreign key([IDEMPRESA]) references [TB_EMPRESA] ([IDEMPRESA])  on update no action on delete no action 
go
Alter table [TB_BOLETO_EMITIDO] add  foreign key([IDEMPRESA]) references [TB_EMPRESA] ([IDEMPRESA])  on update no action on delete no action 
go
Alter table [TB_RECIBO] add  foreign key([IDEMPRESA]) references [TB_EMPRESA] ([IDEMPRESA])  on update no action on delete no action 
go
Alter table [TB_PERFIL] add  foreign key([IDEMPRESA]) references [TB_EMPRESA] ([IDEMPRESA])  on update no action on delete no action 
go
Alter table [TB_CONTAS_PAGAR] add  foreign key([IDEMPRESA]) references [TB_EMPRESA] ([IDEMPRESA])  on update no action on delete no action 
go
Alter table [TB_CONTAS_RECEBER] add  foreign key([IDCLIENTEFORNECEDOR]) references [TB_CLIENTE_FORNECEDOR] ([IDCLIENTEFORNECEDOR])  on update no action on delete no action 
go
Alter table [TB_RECIBO] add  foreign key([IDCLIENTEFORNECEDOR]) references [TB_CLIENTE_FORNECEDOR] ([IDCLIENTEFORNECEDOR])  on update no action on delete no action 
go
Alter table [TB_BOLETO_EMITIDO] add  foreign key([IDCLIENTEFORNECEDOR]) references [TB_CLIENTE_FORNECEDOR] ([IDCLIENTEFORNECEDOR])  on update no action on delete no action 
go
Alter table [TB_CONTAS_PAGAR] add  foreign key([IDCLIENTEFORNECEDOR]) references [TB_CLIENTE_FORNECEDOR] ([IDCLIENTEFORNECEDOR])  on update no action on delete no action 
go
Alter table [TB_CLIENTE_SERVICO] add  foreign key([IDCLIENTEFORNECEDOR]) references [TB_CLIENTE_FORNECEDOR] ([IDCLIENTEFORNECEDOR])  on update no action on delete no action 
go
Alter table [TB_CONTAS_RECEBER] add  foreign key([IDPLANOCONTAS]) references [TB_PLANO_CONTAS] ([IDPLANOCONTAS])  on update no action on delete no action 
go
Alter table [TB_CONTAS_PAGAR] add  foreign key([IDPLANOCONTAS]) references [TB_PLANO_CONTAS] ([IDPLANOCONTAS])  on update no action on delete no action 
go
Alter table [TB_CONTAS_RECEBER] add  foreign key([IDBANCO]) references [TB_BANCO] ([IDBANCO])  on update no action on delete no action 
go
Alter table [TB_CONTAS_PAGAR] add  foreign key([IDBANCO]) references [TB_BANCO] ([IDBANCO])  on update no action on delete no action 
go
Alter table [TB_CONTAS_RECEBER] add  foreign key([IDUSUARIO]) references [TB_USUARIO] ([IDUSUARIO])  on update no action on delete no action 
go
Alter table [TB_BANCO] add  foreign key([IDUSUARIO]) references [TB_USUARIO] ([IDUSUARIO])  on update no action on delete no action 
go
Alter table [TB_PLANO_CONTAS] add  foreign key([IDUSUARIO]) references [TB_USUARIO] ([IDUSUARIO])  on update no action on delete no action 
go
Alter table [TB_CLIENTE_FORNECEDOR] add  foreign key([IDUSUARIO]) references [TB_USUARIO] ([IDUSUARIO])  on update no action on delete no action 
go
Alter table [TB_PRODUTO_SERVICO] add  foreign key([IDUSUARIO]) references [TB_USUARIO] ([IDUSUARIO])  on update no action on delete no action 
go
Alter table [TB_BOLETO_EMITIDO] add  foreign key([IDUSUARIO]) references [TB_USUARIO] ([IDUSUARIO])  on update no action on delete no action 
go
Alter table [TB_RECIBO] add  foreign key([IDUSUARIO]) references [TB_USUARIO] ([IDUSUARIO])  on update no action on delete no action 
go
Alter table [TB_CONTAS_PAGAR] add  foreign key([IDUSUARIO]) references [TB_USUARIO] ([IDUSUARIO])  on update no action on delete no action 
go
Alter table [TB_USUARIO] add  foreign key([IDPERFIL]) references [TB_PERFIL] ([IDPERFIL])  on update no action on delete no action 
go
Alter table [TB_CONTAS_RECEBER] add  foreign key([IDPRODUTO]) references [TB_PRODUTO_SERVICO] ([IDPRODUTO])  on update no action on delete no action 
go
Alter table [TB_CLIENTE_SERVICO] add  foreign key([IDPRODUTO]) references [TB_PRODUTO_SERVICO] ([IDPRODUTO])  on update no action on delete no action 
go


Set quoted_identifier on
go

















Set quoted_identifier off
go


