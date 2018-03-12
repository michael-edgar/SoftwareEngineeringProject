DROP TABLE Linen;
DROP TABLE Customers;

CREATE TABLE Linen
(Linen_Code char (3) NOT NULL,
 Linen_Name char (30),
 Hire_Price numeric (6,2),
 Cleaning_Price numeric (6,2),
 Reject_Price numeric (6,2),
 Pack_Size numeric (3),
 Linen_Status char (1),
 CONSTRAINT pk_linen PRIMARY KEY (Linen_Code)); 
 
CREATE TABLE Customer
(Customer_ID numeric (6) NOT NULL,
 Company_Name char (20),
 Contact_Number char (10),
 Customer_Name char (20),
 Email char (30),
 Street char (20),
 Town char (20),
 County char (10),
 Eircode char (8),
 Customer_Status char (1),
 Rejects numeric (6,2),
 CONSTRAINT pk_customer PRIMARY KEY (Customer_ID));
 

