
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
SELECT * FROM Products;

TRUNCATE TABLE Users;
INSERT INTO Users (Names, LastNames, Email, BirthDate, Address, Phone)
VALUES ("Juanky", "Herrera", "juanky@gmail.com", "2005-02-03", "Calle 33 #33D-33", "3177943448"),
("Mateo", "Velez", "mateo@gmail.com", "2001-09-09", "Calle 44 #44D-4", "3144444444"),
("Isabella", "Guzman", "isa@gmail.com", "2006-06-29", "Calle 22 #22D-22", "3122222222"),
("Pablo", "Londoño", "pablo@gmail.com", "2002-12-10", "Calle 11 #11D-11", "3111111111")


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
VALUES ("Gansito", "La diversión hecha sabor", 1700.00, 1, "2004-05-06"),
("Gansito", "La diversión hecha sabor", 1700.00, 1, "2004-05-06")