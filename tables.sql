
CREATE TABLE Teachers (
    TeacherID INT PRIMARY KEY AUTO_INCREMENT, 
    Name VARCHAR(255) NOT NULL,
    Surname VARCHAR(255) NOT NULL,
    Sex VARCHAR(10), 
    Subject VARCHAR(255)
);

CREATE TABLE Pupils (
    PupilID INT PRIMARY KEY AUTO_INCREMENT, 
    Name VARCHAR(255) NOT NULL,
    Surname VARCHAR(255) NOT NULL,
    Sex VARCHAR(10), 
    Class VARCHAR(50)
);


CREATE TABLE TeacherPupilRelationship (
    RelationshipID INT PRIMARY KEY AUTO_INCREMENT, 
    TeacherID INT NOT NULL,
    PupilID INT NOT NULL,
    CONSTRAINT FK_Teacher FOREIGN KEY (TeacherID) REFERENCES Teachers (TeacherID),
    CONSTRAINT FK_Pupil FOREIGN KEY (PupilID) REFERENCES Pupils (PupilID)
);
