--- Entrar na Base de Dados Master
USE MASTER
GO

------------------------
--Criar Base de dados 

CREATE DATABASE LojaProdutos
GO
-------------------------
--Entre na base de dados 

USE LojaProdutos
GO

--------------------------

---- Criando a tabela Vendas

CREATE TABLE Vendas(
Id INT IDENTITY PRIMARY KEY,
Produto VARCHAR (255) not null, 
Descrição VARCHAR(255) not null,
DataVenda DATE not null,
Valor DECIMAL (18) not null
);
GO

---- Insercao de dados 
INSERT INTO Vendas VALUES
('')

SELECT * FROM Vendas
GO
