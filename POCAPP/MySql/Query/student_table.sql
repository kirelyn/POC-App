CREATE TABLE pocapp.student (
id INT UNSIGNED NOT NULL AUTO_INCREMENT,
first_name VARCHAR(30) NOT NULL,
last_name VARCHAR(30) NOT NULL,
phone_number INT UNSIGNED NOT NULL,
email VARCHAR(45) NOT NULL,
priority INT NOT NULL,
PRIMARY KEY(id));

ALTER TABLE pocapp.student AUTO_INCREMENT == 10000000;