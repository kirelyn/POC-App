SELECT d.id, SUM(d.c) AS Count
FROM (
SELECT s.id, count(*) AS c 
FROM student AS s 
join class_schedule AS csched on s.id = csched.student_id
JOIN (SELECT class_id
    FROM class_schedule
    WHERE student_id = 10) AS classes
WHERE csched.class_id = classes.class_id
AND s.id != 10
GROUP BY s.id
UNION ALL
SELECT s.id, count(*) AS count2
FROM student AS s
JOIN club_schedule AS clubsched ON s.id = clubsched.student_id
JOIN (SELECT club_id
    FROM club_schedule
    WHERE student_id = 10) AS clubs
WHERE clubsched.club_id = clubs.club_id
AND s.id != 10
GROUP BY s.id
) AS d
GROUP BY d.id;
