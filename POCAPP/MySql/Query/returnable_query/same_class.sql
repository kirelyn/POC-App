-- to select students that have come into contact with the student
SELECT s.id
FROM student AS s, class AS class, class_schedule AS csched, club AS club, club_schedule AS clubsched
JOIN (SELECT class_id
    FROM class_schedule
    WHERE student_id = 10) AS classes
WHERE csched.class_id = classes.class_id
AND csched.student_id != 10;

