Create database HelpDesk
go

use HelpDesk
go

Create table TipoUsuario(
id_TipoUsuario int identity (1,1) primary key,
desc_TipoUsuario varchar (20) not null,
)
go

insert into TipoUsuario values ('comum')   
insert into TipoUsuario values ('administrador')   

Create table Usuarios(
id_Usuario int identity (1,1) primary key,
id_TipoUsuario int not null,
rg_Usuario varchar (10) not null,
cpf_Usuario varchar (11) not null,
nome_Usuario varchar (100) not null,
tel1_Usuario varchar (11) not null,
tel2_Usuario varchar (11) not null,
email_Usuario varchar (100) not null
CONSTRAINT  fk_TipoUsuario_Usuario  Foreign key (id_TipoUsuario) References TipoUsuario (id_TipoUsuario)
)
go

insert into Usuarios values (1,'377799725','44815102856','Danilo Vinter','985296363','969693636','danlo.vinter@hotmail.com')
insert into Usuarios values (2,'456222233','25635563222','Adiministrador','982223336','970700777','administrador@live.com')

Create table Acesso(
id_Acesso int identity (1,1) primary key,
id_Usuario int null,
nome_Acesso varchar (15) not null,
senha_Acesso varchar (8) not null,
CONSTRAINT  fk_Usuario_Acesso  Foreign key (id_Usuario) References Usuarios (id_Usuario)
)
go

insert into Acesso values ( 2,'user','12345678')   
insert into Acesso values ( 3,'adm','senha123')       

Create table Chamados(
id_Chamado int identity (1,1) primary key,
id_Usuario int null,
id_Funcionario int null,
Setor varchar (60) not null,
Prioridade varchar (40) not null,
Status_Chamado varchar (40) null,
desc_Chamado varchar (255) not null ,
dta_Chamado date not null,
dti_Chamado date null,
dtf_Chamado date null,
solucao_Chamado varchar (255) null,
CONSTRAINT  fk_Usuario_Chamado  Foreign key (id_Usuario) References Usuarios (id_Usuario),
CONSTRAINT  fk_Funcionario_Chamado  Foreign key (id_Funcionario) References Usuarios (id_Usuario)
);
go

select * from Usuarios

select * from TipoUsuario

select * from Chamados 

select id_Chamado , Setor, Prioridade, desc_Chamado, dti_Chamado from Chamados where id_Usuario = 2 

select * from Acesso

update Chamados	set solucao_Chamado = 'solucionado' where id_Chamado = 12

select * from Chamados where Status_Chamado = 'Finalizado' and id_Funcionario = 3

delete from Chamados where Status_Chamado = 'Aberto'