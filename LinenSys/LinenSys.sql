DROP TABLE Linen;
DROP TABLE Customer;
DROP TABLE Orders;
DROP TABLE OrderItem;
DROP TABLE Rejects;

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
 
CREATE TABLE Orders
(Order_ID numeric (6) NOT NULL,
 Order_Date date,
 Delivery_Date date,
 Order_Status char (1),
 Order_Type char(1),
 Customer_ID numeric (6),
 CONSTRAINT pk_orders PRIMARY KEY (Order_ID),
 CONSTRAINT fk_orders_customer FOREIGN KEY (Customer_ID) references Customer);

CREATE TABLE OrderItem
(Order_Item numeric (6) NOT NULL,
 Linen_Amount numeric (6,2),
 Linen_Code char (3),
 Order_ID numeric (6),
 CONSTRAINT pk_orderItem PRIMARY KEY (Order_Item),
 CONSTRAINT fk_orderItem_orders FOREIGN KEY (Order_ID) references Orders);
 
CREATE TABLE Rejects
(Reject_ID numeric (6) NOT NULL,
 Reject_Date date,
 Reject_Qty numeric (3),
 Linen_Code char (3),
 Order_ID numeric (6),
 CONSTRAINT pk_rejects PRIMARY KEY (Reject_ID),
 CONSTRAINT fk_rejects_linen FOREIGN KEY (Linen_Code) references Linen,
 CONSTRAINT fk_rejects_orders FOREIGN KEY (Order_ID) references Orders);
 

