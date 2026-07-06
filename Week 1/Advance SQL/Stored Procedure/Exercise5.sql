CREATE TABLE Products (
    ProductId INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2),
    StockQty INT
);

INSERT INTO Products (ProductId, ProductName, Category, Price, StockQty) VALUES
(1, 'Wireless Mouse', 'Electronics', 1200.00, 50),
(2, 'Bluetooth Speaker', 'Electronics', 2500.00, 20),
(3, 'Office Chair', 'Furniture', 8500.00, 10),
(4, 'Running Shoes', 'Footwear', 3200.00, 35);


-- Method 1: Returning data via a SELECT result set
CREATE PROCEDURE GetProductById
    @ProductId INT
AS
BEGIN
    SELECT ProductId, ProductName, Category, Price, StockQty
    FROM Products
    WHERE ProductId = @ProductId;
END;

-- Execute and view the returned result set
EXEC GetProductById @ProductId = 2;


-- Method 2: Returning a value via an OUTPUT parameter
CREATE PROCEDURE GetProductPrice
    @ProductId INT,
    @Price DECIMAL(10,2) OUTPUT
AS
BEGIN
    SELECT @Price = Price
    FROM Products
    WHERE ProductId = @ProductId;
END;

-- Execute and capture the output value into a variable
DECLARE @ResultPrice DECIMAL(10,2);
EXEC GetProductPrice @ProductId = 3, @Price = @ResultPrice OUTPUT;
SELECT @ResultPrice AS ProductPrice;


-- Method 3: Returning a status code via RETURN
CREATE PROCEDURE CheckStock
    @ProductId INT
AS
BEGIN
    DECLARE @Qty INT;

    SELECT @Qty = StockQty
    FROM Products
    WHERE ProductId = @ProductId;

    IF @Qty IS NULL
        RETURN -1;       -- Product not found
    ELSE IF @Qty = 0
        RETURN 0;        -- Out of stock
    ELSE
        RETURN 1;        -- In stock
END;

-- Execute and capture the return status into a variable
DECLARE @Status INT;
EXEC @Status = CheckStock @ProductId = 4;
SELECT @Status AS StockStatus;