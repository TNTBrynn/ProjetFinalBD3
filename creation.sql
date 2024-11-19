
USE BDB56Projet2GS
GO

-- Table: Provinces
CREATE TABLE Provinces (
    Id CHAR(2) NOT NULL PRIMARY KEY,
    Nom NVARCHAR(50) NOT NULL,
    Remarque NVARCHAR(MAX) NULL
);

-- Table: TypesEmploye
CREATE TABLE TypesEmploye (
    No INT NOT NULL PRIMARY KEY,
    Description NVARCHAR(100) NOT NULL,
    Remarque NVARCHAR(MAX) NULL
);

-- Table: Employes
CREATE TABLE Employes (
    No INT NOT NULL PRIMARY KEY,
    MotDePasse NVARCHAR(50) NOT NULL,
    Nom NVARCHAR(50) NOT NULL,
    Prenom NVARCHAR(50) NOT NULL,
    Sexe CHAR(1) NOT NULL CHECK (Sexe IN ('H', 'F')),
    Age INT NOT NULL,
    NoCivique INT NOT NULL,
    Rue NVARCHAR(100) NOT NULL,
    Ville NVARCHAR(50) NOT NULL,
    IdProvince CHAR(2) NOT NULL FOREIGN KEY REFERENCES Provinces(Id),
    CodePostal CHAR(6) NOT NULL,
    Telephone CHAR(10) NOT NULL,
    Cellulaire CHAR(10) NULL,
    Courriel NVARCHAR(100) NOT NULL,
    SalaireHoraire MONEY NOT NULL,
    NoTypeEmploye INT NOT NULL FOREIGN KEY REFERENCES TypesEmploye(No),
    Remarque NVARCHAR(MAX) NULL
);

-- Table: TypesAbonnement
CREATE TABLE TypesAbonnement (
    No INT NOT NULL PRIMARY KEY,
    Description NVARCHAR(100) NOT NULL,
    Remarque NVARCHAR(MAX) NULL
);

-- Table: Abonnements
CREATE TABLE Abonnements (
    Id NVARCHAR(50) NOT NULL PRIMARY KEY,
    DateAbonnement DATE NOT NULL,
    Nom NVARCHAR(50) NOT NULL,
    Prenom NVARCHAR(50) NOT NULL,
    Sexe CHAR(1) NOT NULL CHECK (Sexe IN ('H', 'F')),
    DateNaissance DATE NOT NULL,
    NoCivique INT NOT NULL,
    Rue NVARCHAR(100) NOT NULL,
    Ville NVARCHAR(50) NOT NULL,
    IdProvince CHAR(2) NOT NULL FOREIGN KEY REFERENCES Provinces(Id),
    CodePostal CHAR(6) NOT NULL,
    Telephone CHAR(10) NOT NULL,
    Cellulaire CHAR(10) NULL,
    Courriel NVARCHAR(100) NOT NULL,
    NoTypeAbonnement INT NOT NULL FOREIGN KEY REFERENCES TypesAbonnement(No),
    Remarque NVARCHAR(MAX) NULL
);

-- Table: Dependants
CREATE TABLE Dependants (
    Id NVARCHAR(50) NOT NULL PRIMARY KEY,
    Nom NVARCHAR(50) NOT NULL,
    Prenom NVARCHAR(50) NOT NULL,
    Sexe CHAR(1) NOT NULL CHECK (Sexe IN ('H', 'F')),
    DateNaissance DATE NOT NULL,
    IdAbonnement NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Abonnements(Id),
    Remarque NVARCHAR(MAX) NULL
);

-- Table: Services
CREATE TABLE Services (
    No INT NOT NULL PRIMARY KEY,
    TypeService NVARCHAR(100) NOT NULL,
    NoEmploye INT NOT NULL FOREIGN KEY REFERENCES Employes(No),
    Remarque NVARCHAR(MAX) NULL
);

-- Table: Depenses
CREATE TABLE Depenses (
    No INT NOT NULL PRIMARY KEY,
    IdAbonnement NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Abonnements(Id),
    DateDepense DATE NOT NULL,
    Montant MONEY NOT NULL,
    NoService INT NOT NULL FOREIGN KEY REFERENCES Services(No),
    Remarque NVARCHAR(MAX) NULL
);

-- Table: Terrains
CREATE TABLE Terrains (
    No INT NOT NULL PRIMARY KEY,
    Nom NVARCHAR(100) NOT NULL,
    NombreTrous INT NOT NULL,
    Description NVARCHAR(255) NOT NULL,
    Remarque NVARCHAR(MAX) NULL
);

-- Table: PartiesJouees
CREATE TABLE PartiesJouees (
    IdAbonnement NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Abonnements(Id),
    NoTerrain INT NOT NULL FOREIGN KEY REFERENCES Terrains(No),
    DatePartie DATE NOT NULL,
    Pointage INT NOT NULL,
    Remarque NVARCHAR(MAX) NULL,
    PRIMARY KEY (IdAbonnement, NoTerrain, DatePartie)
);

-- Table: Reabonnements
CREATE TABLE Reabonnements (
    IdAbonnement NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Abonnements(Id),
    DateRenouvellement DATE NOT NULL,
    Remarque NVARCHAR(MAX) NULL,
    PRIMARY KEY (IdAbonnement, DateRenouvellement)
);

-- Table: PrixDepensesAbonnements
CREATE TABLE PrixDepensesAbonnements (
    NoTypeAbonnement INT NOT NULL FOREIGN KEY REFERENCES TypesAbonnement(No),
    Annee INT NOT NULL,
    Prix MONEY NOT NULL,
    DepensesObligatoires MONEY NOT NULL,
    Remarque NVARCHAR(MAX) NULL,
    PRIMARY KEY (NoTypeAbonnement, Annee)
);
GO


