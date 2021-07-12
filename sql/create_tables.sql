
-- Creation of student table
CREATE TABLE IF NOT EXISTS student (
  id INT NOT NULL,
  first_name varchar(250) NOT NULL,
  last_name varchar(250) NOT NULL,
  email varchar(250) NOT NULL,
  PRIMARY KEY (id)
);

-- Creation of course table
CREATE TABLE IF NOT EXISTS course (
  id INT NOT NULL,
  name varchar(450) NOT NULL,
  students int[],
  max_students_allowed int NOT NULL,
  PRIMARY KEY (id)
);

-- Creation of grade table
CREATE TABLE IF NOT EXISTS grade (
  grade int NOT NULL,
  student_id int, -- NOT NULL due to PK below
  course_id int,  -- NOT NULL due to PK below
  PRIMARY KEY (student_id, course_id),
  CONSTRAINT fk_student_id
      FOREIGN KEY(student_id) 
	  REFERENCES student(id),
  CONSTRAINT fk_course_id
      FOREIGN KEY(course_id) 
	  REFERENCES course(id)  
);

