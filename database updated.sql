-- ========================================================
-- 1. USERS TABLE
-- ========================================================
CREATE TABLE tblUser (
    user_id INT PRIMARY KEY IDENTITY(1,1),
    userName VARCHAR(50) NOT NULL UNIQUE,
    passWord VARCHAR(255) NOT NULL,
    usertype VARCHAR(30) NOT NULL,
    recoveryQuestion VARCHAR(100),
    recoveryAnswer VARCHAR(100),
    userStatus BIT DEFAULT 1 -- 1 = Active, 0 = Inactive
);

-- ========================================================
-- 2. CUSTOMERS TABLE
-- ========================================================
CREATE TABLE tblCustomer (
    customer_id INT PRIMARY KEY IDENTITY(1,1),
    customer_name VARCHAR(100) NOT NULL,
    customer_phone VARCHAR(20),
    customer_address VARCHAR(255),
    date DATETIME DEFAULT GETDATE()
);

-- ========================================================
-- 3. PRODUCTS TABLE
-- ========================================================
CREATE TABLE tblProduct (
    product_id INT PRIMARY KEY IDENTITY(1,1),
    product_name VARCHAR(100) NOT NULL UNIQUE,
    product_type VARCHAR(50),
    quantity INT NOT NULL DEFAULT 0,
    barcode VARCHAR(50) UNIQUE,
    cost MONEY NOT NULL,
    price MONEY NOT NULL,
    date DATETIME DEFAULT GETDATE(),
    deleted BIT DEFAULT 0
);

-- ========================================================
-- 4. INVOICES TABLE (Master Header)
-- Relationship: Belongs to 1 Customer, Created by 1 User
-- ========================================================
CREATE TABLE tblInvoice (
    invoice_id INT PRIMARY KEY IDENTITY(1,1),
    invoice_no VARCHAR(50) NOT NULL UNIQUE,
    customer_id INT NOT NULL,
    user_id INT NULL,
    sale_date DATETIME NOT NULL DEFAULT GETDATE(),
    subtotal DECIMAL(18,2) NOT NULL,
    discount DECIMAL(18,2) DEFAULT 0.00,
    grand_total DECIMAL(18,2) NOT NULL,
    total_profit DECIMAL(18,2) DEFAULT 0.00,
    status VARCHAR(20) DEFAULT 'Completed', -- Completed, Cancelled, Returned
    deleted BIT DEFAULT 0,
    
    -- Relationships & Constraints
    CONSTRAINT FK_Invoice_Customer FOREIGN KEY (customer_id) 
        REFERENCES tblCustomer(customer_id) 
        ON UPDATE CASCADE,
        
    CONSTRAINT FK_Invoice_User FOREIGN KEY (user_id) 
        REFERENCES tblUser(user_id) 
        ON DELETE SET NULL 
        ON UPDATE CASCADE
);

-- ========================================================
-- 5. SALES LINE ITEMS TABLE (Detail)
-- Relationship: Belongs to 1 Invoice, References 1 Product
-- ========================================================
CREATE TABLE tblSalesItem (
    sale_item_id INT PRIMARY KEY IDENTITY(1,1),
    invoice_id INT NOT NULL,
    product_id INT NOT NULL,
    item_name VARCHAR(100) NOT NULL,
    quantity INT NOT NULL,
    price MONEY NOT NULL,
    discount DECIMAL(18,2) DEFAULT 0.00,
    netPrice MONEY NOT NULL,
    profit MONEY NOT NULL,
    returned BIT DEFAULT 0,
    deleted BIT DEFAULT 0,
    
    -- Relationships & Constraints
    -- ON DELETE CASCADE: If an invoice is deleted, its line items are automatically cleaned up.
    CONSTRAINT FK_SalesItem_Invoice FOREIGN KEY (invoice_id) 
        REFERENCES tblInvoice(invoice_id) 
        ON DELETE CASCADE 
        ON UPDATE CASCADE,
        
    -- ON DELETE RESTRICT (Default): Prevent deleting a product if it has past sales history.
    CONSTRAINT FK_SalesItem_Product FOREIGN KEY (product_id) 
        REFERENCES tblProduct(product_id) 
        ON UPDATE CASCADE
);

-- ========================================================
-- 6. PAYMENTS TABLE
-- Relationship: Belongs to 1 Invoice
-- ========================================================
CREATE TABLE tblPayment (
    payment_id INT PRIMARY KEY IDENTITY(1,1),
    invoice_id INT NOT NULL,
    paymentAmount MONEY NOT NULL,
    paymentMethod VARCHAR(30) NOT NULL, -- Cash, Card, Mobile Money (ZAAD/WAAFI)
    paymentStatus VARCHAR(20) DEFAULT 'Paid',
    date DATETIME DEFAULT GETDATE(),
    returned BIT DEFAULT 0,
    
    -- Relationships & Constraints
    CONSTRAINT FK_Payment_Invoice FOREIGN KEY (invoice_id) 
        REFERENCES tblInvoice(invoice_id) 
        ON DELETE CASCADE 
        ON UPDATE CASCADE
);

-- ========================================================
-- 7. PERFORMANCE INDEXES ON FOREIGN KEYS
-- Essential for fast reporting joins and invoice searches
-- ========================================================
CREATE INDEX IX_Invoice_Customer ON tblInvoice(customer_id);
CREATE INDEX IX_SalesItem_Invoice ON tblSalesItem(invoice_id);
CREATE INDEX IX_SalesItem_Product ON tblSalesItem(product_id);
CREATE INDEX IX_Payment_Invoice ON tblPayment(invoice_id);