CREATE TABLE Prodotto(
	prodottoID INTEGER IDENTITY(1859,125) PRIMARY KEY,
	nome VARCHAR(250) NOT NULL,
	codice VARCHAR(10) NOT NULL UNIQUE,
	quantita DECIMAL(5,2) DEFAULT 0
);

INSERT INTO Prodotto(nome, codice, quantita) VALUES
('Nutella', 'NUT123', 12.5);

INSERT INTO Prodotto(nome, codice, quantita) VALUES
('Biscotti', 'BIS127', 115);

SELECT * FROM Prodotto;