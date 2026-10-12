create table tblUser(
user_id int primary key identity(1,1),
userName varchar(20),
passWord varchar(30),
usertype varchar(30),
recoveryQuestion varchar(100),
recoveryAnswer varchar(100),
userStatus varchar(10),
);

Create table tblCustomer (
customer_id int primary key identity (1,1) ,
customer_name varchar(40),
customer_phone numeric,
customer_address varchar(40),
date datetime
);

Create table tblProduct (
product_id int primary key identity (1,1), 
product_name varchar(40) unique, 
product_type varchar(20), 
quantity int, 
barcode int, 
cost money, 
price money,
date datetime,
deleted varchar(10)
);

Create table tblPayment (
payment_id int primary key identity (1,1), 
customer_id int foreign key references tblCustomer(customer_id), 
paymentStatus varchar(20), 
paymentAmount money, 
paymentMethod varchar(20), 
date datetime,
returned varchar(20),
);

Create table tblSales (
sale_id int primary key identity (1,1), 
product_id int foreign key references tblProduct(product_id), 
item_name varchar(40), 
quantity int, 
price money, 
discount int, 
netPrice money, 
payment_id int foreign key references tblPayment(payment_id), 
customer_id int foreign key references tblCustomer(customer_id), 
date datetime,
profit money,
returned varchar(30),
deleted varchar(10)
);

CREATE TABLE tblInvoice (
    invoice_id INT IDENTITY(1,1) PRIMARY KEY,
    invoice_no VARCHAR(50) NOT NULL UNIQUE,
    customer_id INT NOT NULL,
    payment_id INT NOT NULL,
    sale_date DATETIME NOT NULL DEFAULT GETDATE(),
    subtotal DECIMAL(18,2) NOT NULL,
    discount DECIMAL(18,2) DEFAULT 0.00,
    grand_total DECIMAL(18,2) NOT NULL,
    total_profit DECIMAL(18,2) DEFAULT 0.00,
    status VARCHAR(20) DEFAULT 'Completed', -- Completed, Cancelled, Returned
    deleted BIT DEFAULT 0
);