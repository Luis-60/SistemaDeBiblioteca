CREATE DATABASE biblioteca

CREATE TABLE Emprestimo (
  id INT NOT NULL IDENTITY,
  DataSaida DATE NOT NULL,
  DataPrevistaEntrega DATE NOT NULL,
  PRIMARY KEY(id)
);

CREATE TABLE Genero (
  id INT NOT NULL IDENTITY,
  Nome VARCHAR(50) NOT NULL,
  PRIMARY KEY(id)
);

CREATE TABLE Idioma (
  id INT NOT NULL IDENTITY,
  Nome VARCHAR(50) NOT NULL,
  PRIMARY KEY(id)
);

CREATE TABLE Editora (
  id INT NOT NULL IDENTITY,
  Nome VARCHAR(50) NOT NULL,
  PRIMARY KEY(id)
);

CREATE TABLE Autor (
  id INT NOT NULL IDENTITY,
  Nome VARCHAR(50) NOT NULL,
  PRIMARY KEY(id)
);

CREATE TABLE Configuracao (
  id INT NOT NULL IDENTITY,
  QtdDiasEmprestimo INT NOT NULL,
  ValorDiariaAtraso FLOAT NOT NULL,
  PRIMARY KEY(id)
);

CREATE TABLE Pessoa (
  id INT NOT NULL IDENTITY,
  idPessoa INT NOT NULL,
  Nome VARCHAR(50) NOT NULL,
  PRIMARY KEY(id),
  INDEX Pessoa_FKIndex1(idPessoa),
  FOREIGN KEY(idPessoa)
    REFERENCES Emprestimo(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE Livro (
  id INT NOT NULL IDENTITY,
  idIdioma INT NOT NULL,
  idGenero INT NOT NULL,
  idEditora INT NOT NULL,
  ISBN VARCHAR(20) NOT NULL,
  Nome VARCHAR(50) NOT NULL,
  Descricao VARCHAR(255) NULL,
  Edicao INT NOT NULL,
  QtdPaginas INT NOT NULL,
  PRIMARY KEY(id),
  INDEX Livro_FKIndex1(idGenero),
  INDEX Livro_FKIndex2(idEditora),
  INDEX Livro_FKIndex3(idIdioma),
  FOREIGN KEY(idGenero)
    REFERENCES Genero(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(idEditora)
    REFERENCES Editora(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(idIdioma)
    REFERENCES Idioma(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE LivroEmprestado (
  idEmprestimo INT NOT NULL,
  idLivro INT NOT NULL,
  DataEntrega DATE NULL,
  DiasAtraso INT NULL,
  ValorMulta FLOAT NULL,
  ValorPago FLOAT NULL,
  PRIMARY KEY(idEmprestimo, idLivro),
  INDEX Emprestimo_has_Livro_FKIndex1(idEmprestimo),
  INDEX Emprestimo_has_Livro_FKIndex2(idLivro),
  FOREIGN KEY(idEmprestimo)
    REFERENCES Emprestimo(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(idLivro)
    REFERENCES Livro(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE AutorLivro (
  idLivro INT NOT NULL,
  idAutor INT NOT NULL,
  PRIMARY KEY(idLivro, idAutor),
  INDEX Livro_has_Autor_FKIndex1(idLivro),
  INDEX Livro_has_Autor_FKIndex2(idAutor),
  FOREIGN KEY(idLivro)
    REFERENCES Livro(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(idAutor)
    REFERENCES Autor(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE Usuario (
  id INT NOT NULL IDENTITY,
  Nome VARCHAR(50) NOT NULL,
  Email VARCHAR(50) NOT NULL,
  Tipo VARCHAR(50) NOT NULL, 
  Senha VARCHAR(50) NOT NULL,
  PRIMARY KEY(id)
);

INSERT INTO Usuario VALUES ('ADM', 'ADM@adm.com', 'ADM', 'ADM');
