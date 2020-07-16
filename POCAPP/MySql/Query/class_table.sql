CREATE TABLE pocapp.class (
class_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
professor_id INT UNSIGNED NOT NULL,
Primary Key (class_id),
Foreign Key (professor_id) REFERENCES pocapp.professor (id));

