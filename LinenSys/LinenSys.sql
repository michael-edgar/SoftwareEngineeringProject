DROP TABLE Linen;

CREATE TABLE Linen
(Linen_Code char (3) NOT NULL,
 Linen_Name char (30),
 Hire_Price numeric (6,2),
 Cleaning_Price numeric (6,2),
 Reject_Price numeric (6,2),
 Pack_Size numeric (3),
 Linen_Status char (1),
 CONSTRAINT pk_linen PRIMARY KEY (Linen_Code)); 
 

