CREATE TABLE pocapp.club_schedule (
	id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    student_id INT UNSIGNED NOT NULL,
    club_id INT UNSIGNED NOT NULL,
    professor_id INT UNSIGNED NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (student_id) REFERENCES pocapp.student (id),
    FOREIGN KEY (club_id) REFERENCES pocapp.club (club_id),
    FOREIGN KEY (professor_id) REFERENCES pocapp.professor (id));