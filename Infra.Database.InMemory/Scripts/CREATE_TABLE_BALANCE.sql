USE CRIPTO_BROKER;

CREATE TABLE Balance (
UserId int  PRIMARY KEY Identity(1,1),
TotalBalance decimal(10, 2)
)

INSERT INTO Balance VALUES(1000);