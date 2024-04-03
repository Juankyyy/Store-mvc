-- TRUNCATE TABLE Users;

CREATE TABLE Users (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Names VARCHAR(45) NOT NULL,
    LastNames VARCHAR(45) NOT NULL,
    Email VARCHAR(45) UNIQUE NOT NULL,
    BirthDate DATE NOT NULL,
    Address VARCHAR(45) NOT NULL,
    Phone VARCHAR(45) UNIQUE NOT NULL
);

SELECT * FROM Users;

INSERT INTO Users (Names, LastNames, Email, BirthDate, Address, Phone)
VALUES ("Juanky", "Herrera", "juanky@gmail.com", "2005-02-03", "Calle 33 #33D-33", "3177943448");


DROP TABLE Products;
CREATE TABLE Products (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(45) UNIQUE NOT NULL,
    Description VARCHAR(125) NOT NULL,
    Price DOUBLE NOT NULL,
    Amount INT NOT NULL,
    ExpirationDate DATE NOT NULL
);

INSERT INTO Products (Name, Description, Price, Amount, ExpirationDate)
VALUES ("Gansito", "La diversión hecha sabor", 1700.00, 1, "2004-05-06");   