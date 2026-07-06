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

-- Create a stored procedure to fetch all products in a given category
CREATE PROCEDURE GetProductsByCategory
    @Category VARCHAR(50)
AS
BEGIN
    SELECT ProductId, ProductName, Category, Price, StockQty
    FROM Products
    WHERE Category = @Category;
END;

-- Execute the stored procedure
EXEC GetProductsByCategory @Category = 'Electronics';