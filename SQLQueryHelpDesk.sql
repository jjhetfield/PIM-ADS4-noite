Create database HelpDesk
go

use HelpDesk
go

Create table Funcionarios(
id_Funcionario int identity (1,1) primary key,
rg_Funcionario varchar (10) not null,
cpf_Funcionario varchar (11) not null,
nome_Funcionario varchar (100) not null,
tel1_Funcionario varchar (11) not null,
tel2_Funcionario varchar (11) not null,
email_Funcionario varchar (100) not null
)
go

Create table Usuarios(
id_Usuario int identity (1,1) primary key,
rg_Usuario varchar (10) not null,
cpf_Usuario varchar (11) not null,
nome_Usuario varchar (100) not null,
tel1_Usuario varchar (11) not null,
tel2_Usuario varchar (11) not null,
email_Usuario varchar (100) not null
)
go
drop table Chamados
Create table Chamados(
id_Chamado int identity (1,1) primary key,
id_Funcionario int null,
id_Usuario int null,
Setor varchar (60) not null,
Prioridade varchar (40) not null,
Status_Chamado varchar (40) null,
desc_Chamado varchar (255) not null ,
dti_Chamado date not null,
dtf_Chamado date null,
solucao_Chamado varchar (255) null,
CONSTRAINT  fk_Funionario_Chamado  Foreign key (id_Funcionario) References Funcionarios (id_Funcionario),
CONSTRAINT  fk_Usuario_Chamado  Foreign key (id_Usuario) References Usuarios (id_Usuario),
);
go

Create table Acesso(
id_Acesso int identity (1,1) primary key,
id_Funcionario int null,
id_Usuario int null,
nome_Acesso varchar (15) not null,
senha_Acesso varchar (8) not null,
CONSTRAINT  fk_Funionario_Acesso  Foreign key (id_Funcionario) References Funcionarios (id_Funcionario),
CONSTRAINT  fk_Usuario_Acesso  Foreign key (id_Usuario) References Usuarios (id_Usuario),
)
go

select * from Funcionarios
select * from Chamados
insert into Chamados values 
( null, 3, 'almoxarifado', 'Alta', null, 'estou com problemas para cadastrar chamadaos no sistema', '05/10/2018', null, null)

select id_Funcionario from Acesso where nome_Acesso = 'user' and senha_Acesso = '12345678'
select id_Usuario from Acesso where nome_Acesso = 'adm' and senha_Acesso = 'senha123' 

insert into Acesso values ( NUll ,3,'user','12345678')   
insert into Acesso values ( 1 ,NUll,'adm','senha123')    
       
select * from Acesso
select * from Usuarios

insert into Usuarios values ('0','0','Usuario Padrão','0','0','0')
insert into Usuarios values ('377799725','44815102856','Danilo Vinter','985296363','969693636','danlo.vinter@hotmail.com')
