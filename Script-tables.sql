-- Generated by Oracle SQL Developer Data Modeler 17.3.0.261.1529
--   at:        2018-04-22 19:06:25 CEST
--   site:      SQL Server 2012
--   type:      SQL Server 2012

Drop table Zaznam, Typ, Zamestnanec, Pobocka, Ridicovy_skupiny, Vozidlo, Skupina, Ridic

CREATE TABLE Pobocka 
    (
     pobID INTEGER NOT NULL IDENTITY, 
     Ulice VARCHAR (100) NOT NULL , 
     Mesto VARCHAR (100) NOT NULL , 
     Stat VARCHAR (100) NOT NULL , 
     Typ VARCHAR (100) NOT NULL , 
     Stav BIT NOT NULL DEFAULT 1 
    )
    ON "default"
GO 


ALTER TABLE Pobocka 
    ADD 
    CHECK ( Typ IN ('Krajske', 'Mistni', 'Obvodni', 'Reditelstvi') ) 
GO


ALTER TABLE Pobocka 
    ADD 
    CHECK ( Stav IN ('0', '1') ) 
GO

ALTER TABLE Pobocka ADD CONSTRAINT Pobocka_PK PRIMARY KEY CLUSTERED (pobID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Ridic 
    (
     uID INTEGER NOT NULL IDENTITY, 
     Jmeno VARCHAR (100) NOT NULL , 
     Ulice VARCHAR (100) NOT NULL , 
     Mesto VARCHAR (100) NOT NULL , 
     Stat VARCHAR (100) NOT NULL , 
     Obcanstvi VARCHAR (50) NOT NULL , 
     Datum_narozeni DATE NOT NULL , 
     Pocet_bodu INTEGER NOT NULL , 
     Cislo_rp INTEGER NOT NULL, 
     Platnost_rp DATE NOT NULL , 
     Stav BIT NOT NULL DEFAULT 1 
    )
    ON "default"
GO 


ALTER TABLE Ridic 
    ADD 
    CHECK ( Stav IN ('0', '1') ) 
GO

ALTER TABLE Ridic ADD CONSTRAINT Ridic_PK PRIMARY KEY CLUSTERED (uID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Ridicovy_skupiny 
    (
     uID INTEGER NOT NULL , 
     kID INTEGER NOT NULL 
    )
    ON "default"
GO

ALTER TABLE Ridicovy_skupiny ADD CONSTRAINT Ridicovy_skupiny_PK PRIMARY KEY CLUSTERED (uID, kID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Skupina 
    (
     kID INTEGER NOT NULL IDENTITY, 
     Skupina VARCHAR (5) NOT NULL , 
     Popis VARCHAR (100) NOT NULL 
    )
    ON "default"
GO 



ALTER TABLE Skupina ADD CONSTRAINT Skupina_PK PRIMARY KEY CLUSTERED (kID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Typ 
    (
     pID INTEGER NOT NULL IDENTITY, 
     Kategorie VARCHAR (50) NOT NULL , 
     Popis VARCHAR (1000) NOT NULL , 
     Maximalni_vyse INTEGER NOT NULL , 
     Bodovy_trest INTEGER NOT NULL , 
     Stav BIT NOT NULL DEFAULT 1 
    )
    ON "default"
GO 



ALTER TABLE Typ 
    ADD 
    CHECK ( Stav IN ('0', '1') ) 
GO

ALTER TABLE Typ ADD CONSTRAINT Typ_PK PRIMARY KEY CLUSTERED (pID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Vozidlo 
    (
     vID INTEGER NOT NULL IDENTITY, 
     VIN VARCHAR (50) NOT NULL , 
     SPZ VARCHAR (10) NOT NULL , 
     Znacka VARCHAR (100) NOT NULL , 
     Model VARCHAR (100) NOT NULL , 
     Typ VARCHAR (50) NOT NULL , 
     Barva VARCHAR (20) NOT NULL , 
     uID INTEGER NOT NULL , 
     Stav BIT NOT NULL DEFAULT 1 
    )
    ON "default"
GO 


ALTER TABLE Vozidlo 
    ADD 
    CHECK ( Typ IN ('Autobus', 'Motorka', 'Osobn� automobil', 'Ter�nn� automobil', 'Zem�d�lsk� a lesnick� stroje') ) 
GO


ALTER TABLE Vozidlo 
    ADD 
    CHECK ( Stav IN ('0', '1') ) 
GO

ALTER TABLE Vozidlo ADD CONSTRAINT Vozidlo_PK PRIMARY KEY CLUSTERED (vID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Zamestnanec 
    (
     zID INTEGER NOT NULL IDENTITY, 
     Jmeno VARCHAR (100) NOT NULL , 
     Hodnost VARCHAR (50) NOT NULL , 
     pobID INTEGER NOT NULL , 
     Stav BIT NOT NULL DEFAULT 1 
    )
    ON "default"
GO 


ALTER TABLE Zamestnanec 
    ADD 
    CHECK ( Hodnost IN ('Dustojnik', 'General', 'Praporcik') ) 
GO


ALTER TABLE Zamestnanec 
    ADD 
    CHECK ( Stav IN ('0', '1') ) 
GO

ALTER TABLE Zamestnanec ADD CONSTRAINT Zamestnanec_PK PRIMARY KEY CLUSTERED (zID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Zaznam 
    (
     zazID INTEGER NOT NULL IDENTITY, 
     Castka INTEGER NOT NULL , 
     Odebrano_bodu INTEGER NOT NULL , 
     Datum_zadani DATE NOT NULL , 
     Datum_expirace DATE NOT NULL , 
     Datum_provedeni DATE DEFAULT 'NULL' , 
     uID INTEGER NOT NULL , 
     zID INTEGER NOT NULL , 
     pID INTEGER NOT NULL 
    )
    ON "default"
GO

ALTER TABLE Zaznam ADD CONSTRAINT Zaznam_PK PRIMARY KEY CLUSTERED (zazID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

ALTER TABLE Ridicovy_skupiny 
    ADD CONSTRAINT Ridicovy_skupiny_Ridic_FK FOREIGN KEY 
    ( 
     uID
    ) 
    REFERENCES Ridic 
    ( 
     uID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Ridicovy_skupiny 
    ADD CONSTRAINT Ridicovy_skupiny_Skupina_FK FOREIGN KEY 
    ( 
     kID
    ) 
    REFERENCES Skupina 
    ( 
     kID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Vozidlo 
    ADD CONSTRAINT Vozidlo_Ridic_FK FOREIGN KEY 
    ( 
     uID
    ) 
    REFERENCES Ridic 
    ( 
     uID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Zamestnanec 
    ADD CONSTRAINT Zamestnanec_Pobocka_FK FOREIGN KEY 
    ( 
     pobID
    ) 
    REFERENCES Pobocka 
    ( 
     pobID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Zaznam 
    ADD CONSTRAINT Zaznam_Ridic_FK FOREIGN KEY 
    ( 
     uID
    ) 
    REFERENCES Ridic 
    ( 
     uID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Zaznam 
    ADD CONSTRAINT Zaznam_Typ_FK FOREIGN KEY 
    ( 
     pID
    ) 
    REFERENCES Typ 
    ( 
     pID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Zaznam 
    ADD CONSTRAINT Zaznam_Zamestnanec_FK FOREIGN KEY 
    ( 
     zID
    ) 
    REFERENCES Zamestnanec 
    ( 
     zID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO



-- Oracle SQL Developer Data Modeler Summary Report: 
-- 
-- CREATE TABLE                             8
-- CREATE INDEX                             0
-- ALTER TABLE                             25
-- CREATE VIEW                              0
-- ALTER VIEW                               0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE DATABASE                          0
-- CREATE DEFAULT                           0
-- CREATE INDEX ON VIEW                     0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE ROLE                              0
-- CREATE RULE                              0
-- CREATE SCHEMA                            0
-- CREATE SEQUENCE                          0
-- CREATE PARTITION FUNCTION                0
-- CREATE PARTITION SCHEME                  0
-- 
-- DROP DATABASE                            0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0