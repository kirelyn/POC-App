CREATE TABLE pocapp.club (
	club_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    president_id INT UNSIGNED NOT NULL,
    professor_id INT UNSIGNED NOT NULL,
    PRIMARY KEY (club_id),
    FOREIGN KEY (president_id) REFERENCES pocapp.student (id),
    FOREIGN KEY (professor_id) REFERENCES pocapp.student (id));