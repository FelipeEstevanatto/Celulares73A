/*
CREATE DATABASE celularcti;
*/

CREATE TABLE cliente(
    id_cliente BIGSERIAL PRIMARY KEY NOT NULL,
    nome VARCHAR(80) NOT NULL,
	telefone VARCHAR(15) NOT NULL,
	email VARCHAR(80) NOT NULL,
    login varchar(20) UNIQUE NOT NULL,
    senha varchar(10) NOT NULL
);

INSERT INTO cliente (nome, telefone, login, email, senha) 
VALUES 
('Maria da Silva', '(14) 98762-2323', 'mariasilva', 'maria@uol.com.br', '123'),
('Pablo Santos', '(14) 98762-2323', 'pablosantos', 'pablo@uol.com.br', '123'),
('Carla Maria', '(14) 98762-2323', 'carlamaria', 'carla@gmail.com', '123'),
('Carlos Antonio', '(14) 97777-4444', 'carlosantonio', 'caranto@gmail.com.br', '123'),
('Xico Santos', '(14) 98762-2323', 'xicosantos', 'xico@uol.com.br', '123'),
('Luiza Santos', '(14) 93333-5455', 'luizasantos', 'luiza@uol.com.br', '123');

CREATE TABLE fabricante(
    id_fabricante BIGSERIAL PRIMARY KEY NOT NULL,
    nome VARCHAR(150) NOT NULL
);

INSERT INTO fabricante (nome) 
VALUES ('LG'),
('Samsung'),
('Sony'),
('Apple'),
('Motorola'),
('Huawei'),
('Xiaomi'),
('Oppo'),
('Nokia'),
('Asus'),
('Acer'),
('Lenovo'),
('Dell'),
('HP');
   
CREATE TABLE aparelho(
    id_aparelho BIGSERIAL PRIMARY KEY NOT NULL,
    id_fabricante BIGINT NOT NULL,
    modelo 		  VARCHAR(80) NOT NULL,
    altura 			NUMERIC(5,2) NOT NULL DEFAULT 0,
    largura 		NUMERIC(5,2) NOT NULL,
    espessura		NUMERIC(5,2) NOT NULL,
    peso 			NUMERIC(5,2) NOT NULL,
    preco 			NUMERIC(11,2) NOT NULL,
    quantidade 		INT NOT NULL,
    desconto 		NUMERIC(5,2) NOT NULL DEFAULT 0,

    CONSTRAINT fk_fabricante FOREIGN KEY (id_fabricante) 
        REFERENCES fabricante(id_fabricante),
    CONSTRAINT aparelho_id_fabricante_fkey FOREIGN KEY (id_fabricante) 
        REFERENCES fabricante (id_fabricante)
);

INSERT INTO aparelho(id_fabricante, modelo, altura, largura, espessura, peso, preco, quantidade, desconto)
VALUES 
    (2, 'iPhone 6c Roger White', 15.4, 7.6, 1.85, 585, 1999.99, 20, 5),
    (3, 'J5 Black White', 12.4, 6.6, 3.85, 785, 999.99, 15, 8),
    (4, 'Motorola Silver White', 19.4, 9.6, 8.85, 985, 899.99, 22, 15);
   
CREATE TABLE pedido(
    id_pedido 		BIGSERIAL PRIMARY KEY NOT NULL,
    id_aparelho	 	BIGINT NOT NULL,
    datahorapedido	TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,    -- tipo data/hora
    observacao TEXT DEFAULT NULL,
    
    CONSTRAINT pedido_idaparelho_fkey FOREIGN KEY (id_aparelho) 
        REFERENCES aparelho (id_aparelho)
);

/* drop table in cascade
DROP TABLE IF EXISTS cliente, fabricante, aparelho, pedido CASCADE;
*/