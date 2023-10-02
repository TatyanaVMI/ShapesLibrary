/*
 Assume the following database schema:
 Product - Id, Name
 Category - Id, Name

  Relation 'many-to-many' usually implements through a third table. Let's assume such a table is called 'ProductCategory' with columns 'ProductId' and 'CategoryId'
*/

  SELECT Product.Name, Category.Name
  FROM Product
  LEFT JOIN ProductCategory
  ON Product.Id = ProductCategory.ProductId
  LEFT JOIN Category
  ON Category.Id = ProductCategory.CategoryId