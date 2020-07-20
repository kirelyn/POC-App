SELECT d.id, SUM(d.c) AS Count
FROM (
SELECT p.id, count(*) AS c 
FROM professor AS p 
join class_schedule AS csched on p.id = csched.professor_id
JOIN (SELECT class_id
    FROM class_schedule
    WHERE student_id = 10) AS classes
WHERE csched.class_id = classes.class_id
GROUP BY p.id
UNION ALL
SELECT p.id, count(*) AS count2
FROM professor AS p
JOIN club_schedule AS clubsched ON p.id = clubsched.professor_id
JOIN (SELECT club_id
    FROM club_schedule
    WHERE student_id = 10) AS clubs
WHERE clubsched.club_id = clubs.club_id
GROUP BY p.id
) AS d
GROUP BY d.id;
