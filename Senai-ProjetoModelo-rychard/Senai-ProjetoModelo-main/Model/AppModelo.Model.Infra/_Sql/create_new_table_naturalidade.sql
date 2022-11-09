CREATE TABLE naturalidade(
Id int NOT NULL AUTO_INCREMENT,
Descricao varchar(100) NOT NULL,
DataCriacao	datetime NOT NULL,
DataAlteracao datetime NOT NULL,
Ativo boolean NOT NULL,
CONSTRAINT pk_naturalidade_id PRIMARY KEY (Id)
);