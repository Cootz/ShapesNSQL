--ProductToCategory is the junction table that contains ProductId and CategoryId foreign key columns

SELECT Products.Name AS ProductName, Categories.Name AS CategoryName  FROM ProductToCategory
RIGHT JOIN Products
ON ProductToCategory.ProductId=Products.ID
LEFT JOIN Categories
ON ProductToCategory.CategoryId=Categories.ID