
		-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2024-04-03 16:12:42.367

-- tables
-- Table: clients
CREATE TABLE clients (
    id int  NOT NULL IDENTITY,
    address varchar(500)  NULL,
    document varchar(20)  NULL,
    phone int  NULL,
    reference varchar(500)  NULL,
    departments_id varchar(2)  NOT NULL,
    provinces_id varchar(4)  NOT NULL,
    districts_id varchar(6)  NOT NULL,
    CONSTRAINT clients_pk PRIMARY KEY  (id)
);

-- Table: deliveries
CREATE TABLE deliveries (
    id int  NOT NULL IDENTITY,
    client_name varchar(100)  NULL,
    address varchar(200)  NOT NULL,
    reference varchar(200)  NULL,
    instructions varchar(100)  NULL,
    payment_condition varchar(45)  NOT NULL,
    sales_id int  NOT NULL,
    CONSTRAINT deliveries_pk PRIMARY KEY  (id)
);

-- Table: departments
CREATE TABLE departments (
    id varchar(2)  NOT NULL,
    name varchar(45)  NOT NULL,
    CONSTRAINT departments_pk PRIMARY KEY  (id)
);

-- Table: districts
CREATE TABLE districts (
    id varchar(6)  NOT NULL,
    name varchar(45)  NOT NULL,
    provinces_id varchar(4)  NOT NULL,
    departments_id varchar(2)  NOT NULL,
    CONSTRAINT districts_pk PRIMARY KEY  (id)
);

-- Table: payment_condition
CREATE TABLE payment_condition (
    id int  NOT NULL IDENTITY,
    name varchar(100)  NOT NULL,
    CONSTRAINT payment_condition_pk PRIMARY KEY  (id)
);

-- Table: payment_type
CREATE TABLE payment_type (
    id int  NOT NULL IDENTITY,
    name varchar(100)  NOT NULL,
    CONSTRAINT payment_type_pk PRIMARY KEY  (id)
);

-- Table: products
CREATE TABLE products (
    id int  NOT NULL IDENTITY,
    code varchar(50)  NOT NULL,
    description varchar(100)  NOT NULL,
    cost decimal(20,2)  NULL,
    price decimal(20,2)  NULL,
    minimum_stock int  NULL,
    intial_stock int  NULL,
    sizes_id int  NOT NULL,
    CONSTRAINT products_pk PRIMARY KEY  (id)
);

-- Table: products_sales
CREATE TABLE products_sales (
    sales_id int  NOT NULL,
    products_id int  NOT NULL,
    quantity int  NOT NULL,
    CONSTRAINT products_sales_pk PRIMARY KEY  (sales_id,products_id)
);

-- Table: provinces
CREATE TABLE provinces (
    id varchar(4)  NOT NULL,
    name varchar(45)  NOT NULL,
    departments_id varchar(2)  NOT NULL,
    CONSTRAINT provinces_pk PRIMARY KEY  (id)
);

-- Table: rols
CREATE TABLE rols (
    id int  NOT NULL IDENTITY,
    name varchar(45)  NOT NULL,
    CONSTRAINT rols_pk PRIMARY KEY  (id)
);

-- Table: sales
CREATE TABLE sales (
    id int  NOT NULL IDENTITY,
    sale_type varchar(45)  NULL,
    clients_id int  NOT NULL,
    date datetime  NULL,
    phone int  NULL,
    reference varchar(500)  NULL,
    address varchar(200)  NULL,
    payment_type_id int  NOT NULL,
    observation varchar(200)  NULL,
    channel varchar(100)  NULL,
    payment_condition_id int  NOT NULL,
    total decimal(10,2)  NOT NULL,
    cash_payment decimal(10,2)  NULL,
    credit_payment decimal(10,2)  NULL,
    users_id int  NOT NULL,
    CONSTRAINT sales_pk PRIMARY KEY  (id)
);

-- Table: sizes
CREATE TABLE sizes (
    id int  NOT NULL IDENTITY,
    size_name varchar(45)  NOT NULL,
    CONSTRAINT sizes_pk PRIMARY KEY  (id)
);

-- Table: users
CREATE TABLE users (
    id int  NOT NULL IDENTITY,
    user_name varchar(100)  NOT NULL,
    password varchar(45)  NOT NULL,
    rols_id int  NOT NULL,
    CONSTRAINT users_pk PRIMARY KEY  (id)
);

-- foreign keys
-- Reference: clients_departments (table: clients)
ALTER TABLE clients ADD CONSTRAINT clients_departments
    FOREIGN KEY (departments_id)
    REFERENCES departments (id);

-- Reference: clients_districts (table: clients)
ALTER TABLE clients ADD CONSTRAINT clients_districts
    FOREIGN KEY (districts_id)
    REFERENCES districts (id);

-- Reference: clients_provinces (table: clients)
ALTER TABLE clients ADD CONSTRAINT clients_provinces
    FOREIGN KEY (provinces_id)
    REFERENCES provinces (id);

-- Reference: deliveries_sales (table: deliveries)
ALTER TABLE deliveries ADD CONSTRAINT deliveries_sales
    FOREIGN KEY (sales_id)
    REFERENCES sales (id);

-- Reference: districts_departments (table: districts)
ALTER TABLE districts ADD CONSTRAINT districts_departments
    FOREIGN KEY (departments_id)
    REFERENCES departments (id);

-- Reference: districts_provinces (table: districts)
ALTER TABLE districts ADD CONSTRAINT districts_provinces
    FOREIGN KEY (provinces_id)
    REFERENCES provinces (id);

-- Reference: products_sales_products (table: products_sales)
ALTER TABLE products_sales ADD CONSTRAINT products_sales_products
    FOREIGN KEY (products_id)
    REFERENCES products (id);

-- Reference: products_sales_sales (table: products_sales)
ALTER TABLE products_sales ADD CONSTRAINT products_sales_sales
    FOREIGN KEY (sales_id)
    REFERENCES sales (id);

-- Reference: products_sizes (table: products)
ALTER TABLE products ADD CONSTRAINT products_sizes
    FOREIGN KEY (sizes_id)
    REFERENCES sizes (id);

-- Reference: provinces_departments (table: provinces)
ALTER TABLE provinces ADD CONSTRAINT provinces_departments
    FOREIGN KEY (departments_id)
    REFERENCES departments (id);

-- Reference: sales_clients (table: sales)
ALTER TABLE sales ADD CONSTRAINT sales_clients
    FOREIGN KEY (clients_id)
    REFERENCES clients (id);

-- Reference: sales_payment_condition (table: sales)
ALTER TABLE sales ADD CONSTRAINT sales_payment_condition
    FOREIGN KEY (payment_condition_id)
    REFERENCES payment_condition (id);

-- Reference: sales_payment_type (table: sales)
ALTER TABLE sales ADD CONSTRAINT sales_payment_type
    FOREIGN KEY (payment_type_id)
    REFERENCES payment_type (id);

-- Reference: sales_users (table: sales)
ALTER TABLE sales ADD CONSTRAINT sales_users
    FOREIGN KEY (users_id)
    REFERENCES users (id);

-- Reference: users_rols (table: users)
ALTER TABLE users ADD CONSTRAINT users_rols
    FOREIGN KEY (rols_id)
    REFERENCES rols (id);

-- End of file.

