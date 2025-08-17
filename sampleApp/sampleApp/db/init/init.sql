CREATE DATABASE IF NOT EXISTS testdb; # Create the database if it doesn't exist
USE testdb; # Switch to the newly created database

CREATE TABLE IF NOT EXISTS persons (
    Name VARCHAR(255) NOT NULL
);

INSERT INTO persons (Name) VALUES ('Jyothi');
INSERT INTO persons (Name) VALUES ('Teek');
