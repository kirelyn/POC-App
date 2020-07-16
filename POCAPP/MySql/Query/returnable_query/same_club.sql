SELECT DISTINCT s.id
FROM student AS s, class AS class, class_schedule AS csched, club AS club, club_schedule AS clubsched
JOIN (SELECT club_id
    FROM club_schedule
    WHERE student_id = 10) AS clubs
WHERE clubsched.club_id = clubs.club_id
AND s.id != 10;
