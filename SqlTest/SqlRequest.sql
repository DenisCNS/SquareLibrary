SELECT product.name AS product, category.name AS category FROM products
LEFT JOIN product_category on product.id = product_category.id
LEFT JOIN category on product_category.id = category.id
