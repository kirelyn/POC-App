SELECT DISTINCT s.id
FROM student AS s
JOIN club_schedule AS clubsched ON s.id = clubsched.student_id
JOIN (SELECT club_id
    FROM club_schedule
    WHERE student_id = 10) AS clubs
WHERE clubsched.club_id = clubs.club_id
AND s.id != 10;




