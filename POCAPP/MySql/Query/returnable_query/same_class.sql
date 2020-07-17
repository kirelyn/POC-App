-- to select students that have come into contact with the student through class
SELECT DISTINCT s.id
FROM student AS s 
join class_schedule AS csched on s.id = csched.student_id
JOIN (SELECT class_id
    FROM class_schedule
    WHERE student_id = 10) AS classes
WHERE csched.class_id = classes.class_id
AND s.id != 10;



