SELECT Teachers.*
FROM Teachers
JOIN TeacherPupilRelationship ON Teachers.TeacherID = TeacherPupilRelationship.TeacherID
JOIN Pupils ON TeacherPupilRelationship.PupilID = Pupils.PupilID
WHERE Pupils.Name = 'George';
