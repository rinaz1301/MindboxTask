SELECT Product.Name, Category.Name FROM Product 
	LEFT JOIN ProductCategory on Product.Id=ProductCategory.ProductId
	LEFT JOIN Category on ProductCategory.CategoryId=Category.Id