DROP DATABASE bd_Livraria;

CREATE DATABASE bd_Livraria;

USE bd_Livraria;

CREATE TABLE TBL_Editora (
   idEditora INT UNSIGNED NOT NULL AUTO_INCREMENT,
   nome VARCHAR(50) NOT NULL,
   endereco VARCHAR(50) NOT NULL,
   UF char(2) NOT NULL, 
   PRIMARY KEY(idEditora)
);

CREATE TABLE TBL_Autor (
  idAutor INT UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(50) NOT NULL,
  idade INT NOT NULL,
  PRIMARY KEY(idAutor)
);

CREATE TABLE TBL_Livro (
  idLivro INT UNSIGNED NOT NULL AUTO_INCREMENT,
  idAutor INT NOT NULL,
  idEditora INT NOT NULL,
  titulo VARCHAR(50) NOT NULL,
  numPaginas INT NOT NULL,
  valor DOUBLE NOT NULL,
  PRIMARY KEY(idLivro),
  FOREIGN KEY(idAutor) REFERENCES TBL_Autor(idAutor),
  FOREIGN KEY(idEditora) REFERENCES TBL_Editora(idEditora)
);

INSERT INTO TBL_Editora VALUES (NULL, 'Globo', 'Av Nove de Julho, 5229 Jardim Paulista', 'SP');
INSERT INTO TBL_Editora VALUES (NULL, 'Sextante', 'Rua Voluntários da Pátria 45, Rio de Janeiro', 'RJ');
INSERT INTO TBL_Editora VALUES (NULL, 'Ediouro', 'Rua Nova Jerusalém, 345 Bonsucesso', 'RJ');
INSERT INTO TBL_Editora VALUES (NULL, 'Bookman', 'Av Jeronimo de Ornelas, 670 Sala 401 - Santana', 'RS');
INSERT INTO TBL_Editora VALUES (NULL, 'Saraiva', 'Av Olegário Maciel, 1600 - Lourdes', 'MG');
INSERT INTO TBL_Editora VALUES (NULL, 'Alta Books', 'Rua Viúva Cláudio, 291 - Jacaré', 'RJ');
INSERT INTO TBL_Editora VALUES (NULL, 'Vozes', 'Rua dos Tupis, 114 - Centro','MG');

INSERT INTO TBL_Autor VALUES (NULL, 'Pankaj Ghemawat', 57);
INSERT INTO TBL_Autor VALUES (NULL, 'Lawrence J. Gitman', 71);
INSERT INTO TBL_Autor VALUES (NULL, 'George Shepherd', 33);
INSERT INTO TBL_Autor VALUES (NULL, 'Larry J. Goldstein', 61);
INSERT INTO TBL_Autor VALUES (NULL, 'Harold Kerzner', 77);
INSERT INTO TBL_Autor VALUES (NULL, 'Clark,Richard', 42);

INSERT INTO TBL_Livro VALUES(NULL, 1, 4, 'A Estratégia e o Cenário dos Negócios', 176, 45.00);
INSERT INTO TBL_Livro VALUES(NULL, 2, 4, 'Princípos de Administração Financeira', 745, 185.00);
INSERT INTO TBL_Livro VALUES(NULL, 3, 4, 'Microsoft Asp.Net 2.0 Passo a Passo', 407, 40.00);
INSERT INTO TBL_Livro VALUES(NULL, 4, 4, 'Matemática Aplicada', 694, 146.00);
INSERT INTO TBL_Livro VALUES(NULL, 5, 4, 'Gestão de Projetos - as Melhores Práticas', 796, 122.00);
INSERT INTO TBL_Livro VALUES(NULL, 6, 6, 'Introdução ao HTML5 e CSS3', 656, 99.00);

SELECT * FROM TBL_Editora;
SELECT * FROM TBL_Autor;
SELECT * FROM TBL_Livro;