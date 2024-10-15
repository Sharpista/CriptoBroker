USE CRIPTO_BROKER;

CREATE TABLE Transactions (
UserId int,
TransactionId varchar(36),
Amount decimal(10, 8),
Type int, -- 1: Debit, 2: Credit, 3: Rollback
Currency varchar(10),
AmountInBrl decimal(10, 2),
Timestamp datetime,
Description varchar(100),
PRIMARY KEY (TransactionId)
);