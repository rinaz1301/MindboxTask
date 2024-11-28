SELECT Product.Name, Category.Name FROM Product 
	LEFT JOIN ProductCategory on Product.Id=ProductCategory.ProductId
	JOIN Category on ProductCategory.CategoryId=Category.Id