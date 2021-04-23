CREATE TABLE Usuarios(
   Nome varchar(30),
   Telefone varchar(11),
   Email varchar(30),
   Username varchar(12),
   Bio varchar(100),
   UserId int IDENTITY(1,1) PRIMARY KEY,
);

INSERT INTO [dbo].[Usuarios] ([Nome],[Telefone],[Email],[Username],[Bio])
VALUES 
	('Joao Pedro Brandao', '21988888888', 'jp.brs@poli.ufrj.br', 'jpbrs', 'Aluno de ECI. 100 reais a hora de programação'),
	('Pedro Maciel Xavier', '24999999999', 'pedromxavier@poli.ufrj.br', 'pedromxavier', 'Um menino sonhador')
;

CREATE TABLE Tarefas(
   Nome varchar(30) NOT NULL,
   Localidade varchar(30) NOT NULL,
   Cliente varchar(30) NOT NULL,
   Horario SmallDatetime NOT NULL,
   ServiceId int IDENTITY(1,1) PRIMARY KEY,
   UserId int FOREIGN KEY REFERENCES [dbo].[Usuarios](UserId),
);

INSERT INTO [dbo].[Tarefas] ([Nome],[Localidade],[Cliente],[Horario],[UserId])
VALUES 
	('Limpar o laboratorio', 'UFRJ', 'Felipe','2021-04-18 22:22:22', 2),
	('Tomar vergonha na cara', 'Petropolis', 'Pedro', '2021-04-18 22:20:22',2),
	('Criar os Endpoints de PA', 'Rio de Janeiro', 'Grupo de PA', '2021-04-19 00:00:00', 1)
;