CREATE TABLE Users_K (
    id INT PRIMARY KEY,
    login NVARCHAR(40) NOT NULL UNIQUE,
    password NVARCHAR(40) NOT NULL,
    familyname NVARCHAR(40) NOT NULL,
    name NVARCHAR(40) NOT NULL,
    surname NVARCHAR(40),
    education NVARCHAR(100),
    Professional_direction NVARCHAR(60),
    Phone_number NVARCHAR(11)
);

CREATE TABLE Users_C (
    id INT PRIMARY KEY,
    login NVARCHAR(40) NOT NULL UNIQUE,
    password NVARCHAR(40) NOT NULL,
    email NVARCHAR(100) NOT NULL,
    Phone_number NVARCHAR(11)
);