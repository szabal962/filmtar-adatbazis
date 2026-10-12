CREATE DATABASE filmtar
  CHARACTER SET utf8
  COLLATE utf8_hungarian_ci;

USE filmtar;

CREATE TABLE filmek (
  filmID INT PRIMARY KEY,
  cim VARCHAR(60),
  rendezo VARCHAR(40),
  ev INT,
  hossz INT,
  szines BOOLEAN
);

INSERT INTO filmek VALUES
(1, 'Az oroszlánkirály', 'Roger Allers', 1994, 88, 1),
(2, 'A keresztapa', 'Francis Ford Coppola', 1972, 175, 1),
(3, 'Casablanca', 'Michael Curtiz', 1942, 102, 0),
(4, 'A gyűrűk ura', 'Peter Jackson', 2001, 178, 1),
(5, 'Valami Amerika', 'Herendi Gábor', 2002, 110, 1),
(6, 'Kontroll', 'Antal Nimród', 2003, 106, 1),
(7, 'A tanú', 'Bacsó Péter', 1969, 102, 0),
(8, 'Csillagok háborúja', 'George Lucas', 1977, 121, 1),
(9, 'Mátrix', 'Wachowski nővérek', 1999, 136, 1),
(10, 'Pán Péter', 'P. J. Hogan', 2003, 113, 1);
