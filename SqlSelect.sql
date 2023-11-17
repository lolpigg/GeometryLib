CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100)
);

CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(100)
);

CREATE TABLE product_category (
    product_id INT,
    category_id INT,
    FOREIGN KEY (product_id) REFERENCES products(product_id),
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);

SELECT p.product_name, c.category_name
FROM products p
LEFT JOIN product_category pc ON p.product_id = pc.product_id
LEFT JOIN categories c ON pc.category_id = c.category_id;