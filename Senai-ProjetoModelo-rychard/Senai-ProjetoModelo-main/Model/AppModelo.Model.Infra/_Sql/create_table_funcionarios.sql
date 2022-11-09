﻿CREATE TABLE funcionarios(
Id INT NOT NULL AUTO_INCREMENT,
Nome VARCHAR(250) NOT NULL,
Data_Nascimento DATETIME NOT NULL,
Sexo VARCHAR(5) NOT NULL,
Cpf VARCHAR(16) NOT NULL,
Nacionalidade INT NOT NULL,
Naturalidade INT NOT NULL,
Email VARCHAR(250) NOT NULL,
Telefone VARCHAR(16) NOT NULL,
Telefone_Contato VARCHAR(16) NOT NULL,
Cep VARCHAR(12) NOT NULL,
logradouro VARCHAR(250) NOT NULL,
Numero INT NOT NULL,
Complemento VARCHAR(250) NOT NULL,
Bairro VARCHAR(250) NOT NULL,
Municipio VARCHAR(250) NOT NULL,
Uf VARCHAR(2) NOT NULL,
CONSTRAINT pk_funcionarios_id PRIMARY KEY (id),
CONSTRAINT fk_nacionalidades_id FOREIGN KEY (id_nacionalidade) REFERENCES nacionalidades(id),
CONSTRAINT fk_naturalidade_id FOREIGN KEY (id_naturalidade) REFERENCES naturalidade(id)
);