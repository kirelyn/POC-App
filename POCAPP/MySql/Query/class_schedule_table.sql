CREATE TABLE pocapp.class_schedule (
	id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    student_id INT UNSIGNED NOT NULL,
    class_id INT UNSIGNED NOT NULL,
    professor_id INT UNSIGNED NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (student_id) REFERENCES pocapp.student (id),
    FOREIGN KEY (class_id) REFERENCES pocapp.class (class_id),
    FOREIGN KEY (professor_id) REFERENCES pocapp.professor (id));
    