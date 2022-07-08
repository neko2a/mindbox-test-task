SELECT p.Name, c.Name FROM Products p
LEFT JOIN ProductCategories on p.Id = ProductId
LEFT JOIN Categories c on CategoryId = c.Id
