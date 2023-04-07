CREATE TABLE products (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL
);

CREATE TABLE categories (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL
);

CREATE TABLE product_categories (
    product_id INT NOT NULL,
    category_id INT NOT NULL,
    PRIMARY KEY (product_id, category_id),
    FOREIGN KEY (product_id) REFERENCES products(id) ON DELETE CASCADE,
    FOREIGN KEY (category_id) REFERENCES categories(id) ON DELETE CASCADE
);



INSERT INTO products (name)
VALUES
	('Product 1'),
	('Product 2'),
	('Product 3'),
	('Product 4'),
	('Product 5'),
	('Product 6'),
	('Product 7'),
	('Product 8'),
	('Product 9'),
	('Product 10')

INSERT INTO categories (name)
VALUES
	('Category 1'),
	('Category 2'),
	('Category 3'),
	('Category 4'),
	('Category 5')

INSERT INTO product_categories (product_id, category_id) VALUES
(1, 1),
(1, 2),
(2, 1),
(3, 2),
(4, 3),
(4, 4),
(4, 5),
(5, 4),
(9, 1),
(9, 3),
(9, 5),
(10, 2)

SELECT products.[name], categories.[name] FROM products
LEFT JOIN product_categories pc ON products.id = pc.product_id
LEFT JOIN categories ON categories.id = pc.category_id

/*

Product 1	Category 1
Product 1	Category 2
Product 2	Category 1
Product 3	Category 2
Product 4	Category 3
Product 4	Category 4
Product 4	Category 5
Product 5	Category 4
Product 6	NULL
Product 7	NULL
Product 8	NULL
Product 9	Category 1
Product 9	Category 3
Product 9	Category 5
Product 10	Category 2

*/