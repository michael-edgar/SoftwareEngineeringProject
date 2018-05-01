DROP TABLE OrderItem;
DROP TABLE Rejects;
DROP TABLE Orders;
DROP TABLE Linen;
DROP TABLE Customer;

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
 Total_Price numeric (6,2),
 CONSTRAINT pk_orders PRIMARY KEY (Order_ID),
 CONSTRAINT fk_orders_customer FOREIGN KEY (Customer_ID) references Customer);
 
 CREATE TABLE OrderItem
(Order_Item numeric (6) NOT NULL,
 Linen_Amount numeric (6,2),
 Linen_Code char (3),
 Order_ID numeric (6),
 Price numeric (6,2),
 ItemStatus char (1),
 CONSTRAINT pk_orderItem PRIMARY KEY (Order_Item),
 CONSTRAINT fk_orderItem_orders FOREIGN KEY (Order_ID) references Orders,
 CONSTRAINT fk_orderItem_linen FOREIGN KEY (Linen_code) references Linen);
 
CREATE TABLE Rejects
(Reject_ID numeric (6) NOT NULL,
 Reject_Date date,
 Reject_Qty numeric (3),
 Linen_Code char (3),
 Order_ID numeric (6),
 CONSTRAINT pk_rejects PRIMARY KEY (Reject_ID),
 CONSTRAINT fk_rejects_linen FOREIGN KEY (Linen_Code) references Linen,
 CONSTRAINT fk_rejects_orders FOREIGN KEY (Order_ID) references Orders);
 
INSERT INTO Linen
Values('PS', 'Pillow Slip', 34.99, 29.99, 24.99, 50, 'A');

INSERT INTO Linen
Values('KS', 'King Sheet', 24.99, 19.99, 14.99, 5, 'A');

INSERT INTO Linen
Values('SD', 'Single Duvet', 19.99, 14.99, 12.49, 10, 'A');

INSERT INTO Linen
Values('KD', 'King Duvet', 29.99, 24.99, 14.99, 5, 'A');

INSERT INTO Linen
Values('SS', 'Single Sheet', 14.99, 12.49, 9.99, 10, 'A');

INSERT INTO Customer
Values(1, 'The Ashe Hotel', '0859764238', 'Justin O Shea', 'JustinOShea@AsheHotel.ie',
'Ashe Street', 'Tralee', 'Kerry', 'V92 YV9D', 'A', 0);

INSERT INTO Customer
Values(2, 'The Grand Hotel', '0865493215', 'Grainne Mangan', 'GrainneMangan@GrandHotel.ie',
'Denny Street', 'Tralee', 'Kerry', 'V92 YX5F', 'A', 0);

INSERT INTO Orders
Values(1, '23-APR-18', '26-APR-18', 'A', 'D',1, 194.94);

INSERT INTO Orders
Values(2, '23-APR-18', '27-APR-18', 'A', 'D',1, 449.86);

INSERT INTO Orderitem
Values(1, 5, 'PS',1, 174.95, 'A');

INSERT INTO Orderitem
Values(2, 1, 'SD',1, 19.99, 'A');

INSERT INTO Orderitem
Values(3, 10, 'PS',2, 349.90, 'A');

INSERT INTO Orderitem
Values(4, 4, 'KS',2, 99.96, 'A');

COMMIT;
