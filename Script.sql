CREATE DATABASE CarShopping
go
use CarShopping

CREATE TABLE Automovel(
	Id int primary key identity(10,1),
	Modelo varchar(100) NOT NULL,
	Preco decimal NOT NULL
);
CREATE TABLE Ciente(
	Id int primary key identity(10,1),
	Nome varchar(100)
);
CREATE TABLE Concessionarias(
	Id int primary key identity(10,1),
	NomeConcessionaia varchar(100)
);
CREATE TABLE Alocacao(
	Id INT PRIMARY KEY IDENTITY(10,1),
    Area INT NOT NULL,
    IdAutomovel INT NOT NULL,
    Quantidade INT NOT NULL,
    Idconcessionária INT NOT NULL,
    FOREIGN KEY (IdAutomovel) REFERENCES automovel(Id),
    FOREIGN KEY (Idconcessionária) REFERENCES Concessionarias(Id)
);