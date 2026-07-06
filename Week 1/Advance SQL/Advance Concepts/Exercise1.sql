-- Setup: sample table and data
CREATE TABLE Products (
    ProductId INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Products (ProductId, ProductName, Category, Price) VALUES
(1, 'Wireless Mouse', 'Electronics', 1200.00),
(2, 'Bluetooth Speaker', 'Electronics', 2500.00),
(3, 'Gaming Keyboard', 'Electronics', 2500.00),
(4, '4K Monitor', 'Electronics', 18000.00),
(5, 'USB Cable', 'Electronics', 150.00),
(6, 'Office Chair', 'Furniture', 8500.00),
(7, 'Study Table', 'Furniture', 6000.00),
(8, 'Bookshelf', 'Furniture', 6000.00),
(9, 'Recliner Sofa', 'Furniture', 25000.00),
(10, 'Running Shoes', 'Footwear', 3200.00),
(11, 'Formal Shoes', 'Footwear', 3200.00),
(12, 'Sandals', 'Footwear', 800.00);

-- Step 1: ROW_NUMBER() - unique rank within each category
SELECT
    ProductId,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
FROM Products;

-- Step 2: RANK() and DENSE_RANK() - comparing how ties are handled
SELECT
    ProductId,
    ProductName,
    Category,
    Price,
    RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankVal,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankVal
FROM Products;

-- Step 3: Top 3 most expensive products per category (using ROW_NUMBER for an exact cutoff)
WITH RankedProducts AS (
    SELECT
        ProductId,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum,
        RANK()       OVER (PARTITION BY Category ORDER BY Price DESC) AS RankVal,
        DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankVal
    FROM Products
)
SELECT *
FROM RankedProducts
WHERE RowNum <= 3
ORDER BY Category, RowNum;