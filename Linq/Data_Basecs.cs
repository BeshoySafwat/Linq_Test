namespace Linq;

internal static class Data_Base
{


    public static List<Subject> SampleSubjects = new List<Subject>
{
    new Subject
    {
        SubjectId = 1,
        SubjectName = "Mathematics",
        Description = "Study of numbers, quantities, and shapes"
    },
    new Subject
    {
        SubjectId = 2,
        SubjectName = "Computer Science",
        Description = "Study of computation, information, and automation"
    },
    new Subject
    {
        SubjectId = 3,
        SubjectName = "Biology",
        Description = "Study of living organisms and their interactions"
    },
    new Subject
    {
        SubjectId = 4,
        SubjectName = "History",
        Description = "Study of past events and human affairs"
    },
    new Subject
    {
        SubjectId = 5,
        SubjectName = "Literature",
        Description = "Study of written works, especially those of artistic merit"
    }
};

    public static List<Course> SampleCourses = new List<Course>
{
    new Course
    {
        CourseId = 1,
        CourseName = "Calculus I",
        CourseCode = "MATH101",
        SubjectId = 1,  // Mathematics
        InstructorId = 1,
        CourseStartDate = new DateTime(2024, 9, 1),
        Level = CourseLevel.Beginner
    },
    new Course
    {
        CourseId = 2,
        CourseName = "Calculus II",
        CourseCode = "MATH102",
        SubjectId = 1,  // Mathematics
        InstructorId = 2,
        CourseStartDate = new DateTime(2024, 9, 2),
        Level = CourseLevel.Intermediate
    },
    new Course
    {
        CourseId = 3,
        CourseName = "Cell Biology",
        CourseCode = "BIO201",
        SubjectId = 3,  // Biology
        InstructorId = 3,
        CourseStartDate = new DateTime(2024, 9, 3),
        Level = CourseLevel.Intermediate
    },
    new Course
    {
        CourseId = 4,
        CourseName = "World History: Ancient Civilizations",
        CourseCode = "HIST101",
        SubjectId = 4,  // History
        InstructorId = 4,
        CourseStartDate = new DateTime(2024, 9, 4),
        Level = CourseLevel.Beginner
    },
    new Course
    {
        CourseId = 5,
        CourseName = "DataBase",
        CourseCode = "LIT301",
        SubjectId = 2,  // CS
        InstructorId = 5,
        CourseStartDate = new DateTime(2024, 9, 5),
        Level = CourseLevel.Intermediate
    },
    new Course
    {
        CourseId = 6,
        CourseName = "Linear Algebra",
        CourseCode = "MATH201",
        SubjectId = 1,  // Mathematics
        InstructorId = 1,
        CourseStartDate = new DateTime(2024, 9, 6),
        Level = CourseLevel.Intermediate
    },
    new Course
    {
        CourseId = 7,
        CourseName = "Data Structures and Algorithms",
        CourseCode = "CS201",
        SubjectId = 2,  // Computer Science
        InstructorId = 2,
        CourseStartDate = new DateTime(2024, 9, 7),
        Level = CourseLevel.Intermediate
    },
    new Course
    {
        CourseId = 8,
        CourseName = "Genetics",
        CourseCode = "BIO301",
        SubjectId = 3,  // Biology
        InstructorId = 3,
        CourseStartDate = new DateTime(2024, 9, 8),
        Level = CourseLevel.Advanced
    },
    new Course
    {
        CourseId = 9,
        CourseName = "Modern European History",
        CourseCode = "HIST201",
        SubjectId = 4,  // History
        InstructorId = 4,
        CourseStartDate = new DateTime(2024, 9, 9),
        Level = CourseLevel.Intermediate
    },
    new Course
    {
        CourseId = 10,
        CourseName = "Advanced Data Structures and Algorithms",
        CourseCode = "LIT401",
        SubjectId = 2,  // Computer Science
        InstructorId = 5,
        CourseStartDate = new DateTime(2024, 9, 10),
        Level = CourseLevel.Advanced
    }
    };

    public static List<Instructor> SampleInstructors = new List<Instructor>
{
    new Instructor
    {
        InstructorId = 1,
        FirstName = "Emma",
        LastName = "Johnson",
        Email = "emma.johnson@university.edu"
    },
    new Instructor
    {
        InstructorId = 2,
        FirstName = "Michael",
        LastName = "Chen",
        Email = "michael.chen@university.edu"
    },
    new Instructor
    {
        InstructorId = 3,
        FirstName = "Sophia",
        LastName = "Rodriguez",
        Email = "sophia.rodriguez@university.edu"
    },
    new Instructor
    {
        InstructorId = 4,
        FirstName = "David",
        LastName = "Smith",
        Email = "david.smith@university.edu"
    },
    new Instructor
    {
        InstructorId = 5,
        FirstName = "Olivia",
        LastName = "Taylor",
        Email = "olivia.taylor@university.edu"
    },
    new Instructor
    {
        InstructorId = 6,
        FirstName = "James",
        LastName = "Wilson",
        Email = "james.wilson@university.edu"
    },
    new Instructor
    {
        InstructorId = 7,
        FirstName = "Ava",
        LastName = "Brown",
        Email = "ava.brown@university.edu"
    }
};

    public static List<Student> SampleStudents = new List<Student>
{
    new Student
    {
        StudentId = 1,
        FirstName = "Alice",
        LastName = "Walker",
        Email = "alice.walker@student.edu"
    },
    new Student
    {
        StudentId = 2,
        FirstName = "Bob",
        LastName = "Johnson",
        Email = "bob.johnson@student.edu"
    },
    new Student
    {
        StudentId = 3,
        FirstName = "Charlie",
        LastName = "Lee",
        Email = "charlie.lee@student.edu"
    },
    new Student
    {
        StudentId = 4,
        FirstName = "Diana",
        LastName = "Martinez",
        Email = "diana.martinez@student.edu"
    },
    new Student
    {
        StudentId = 5,
        FirstName = "Ethan",
        LastName = "Brown",
        Email = "ethan.brown@student.edu"
    },
    new Student
    {
        StudentId = 6,
        FirstName = "Fiona",
        LastName = "Garcia",
        Email = "fiona.garcia@student.edu"
    },
    new Student
    {
        StudentId = 7,
        FirstName = "George",
        LastName = "Wilson",
        Email = "george.wilson@student.edu"
    },
    new Student
    {
        StudentId = 8,
        FirstName = "Hannah",
        LastName = "Davis",
        Email = "hannah.davis@student.edu"
    },
    new Student
    {
        StudentId = 9,
        FirstName = "Ian",
        LastName = "Taylor",
        Email = "ian.taylor@student.edu"
    },
    new Student
    {
        StudentId = 10,
        FirstName = "Julia",
        LastName = "Anderson",
        Email = "julia.anderson@student.edu"
    },
    new Student
    {
        StudentId = 11,
        FirstName = "Kevin",
        LastName = "Thomas",
        Email = "kevin.thomas@student.edu"
    },
    new Student
    {
        StudentId = 12,
        FirstName = "Laura",
        LastName = "White",
        Email = "laura.white@student.edu"
    },
    new Student
    {
        StudentId = 13,
        FirstName = "Mike",
        LastName = "Harris",
        Email = "mike.harris@student.edu"
    },
    new Student
    {
        StudentId = 14,
        FirstName = "Nina",
        LastName = "Clark",
        Email = "nina.clark@student.edu"
    },
    new Student
    {
        StudentId = 15,
        FirstName = "Oscar",
        LastName = "Lewis",
        Email = "oscar.lewis@student.edu"
    }
};

    public static List<CourseEnrollment> SampleEnrollments = new List<CourseEnrollment>
{
    // Alice Walker (StudentId: 1)
    new CourseEnrollment
    {
        EnrollmentId = 1,
        StudentId = 1,
        CourseId = 1,  // Calculus I
        EnrollmentDate = new DateTime(2024, 1, 15)
    },
    new CourseEnrollment
    {
        EnrollmentId = 2,
        StudentId = 1,
        CourseId = 2,  // Introduction to Programming
        EnrollmentDate = new DateTime(2024, 1, 15)
    },

    // Bob Johnson (StudentId: 2)
    new CourseEnrollment
    {
        EnrollmentId = 3,
        StudentId = 2,
        CourseId = 3,  // Cell Biology
        EnrollmentDate = new DateTime(2024, 1, 16)
    },
    new CourseEnrollment
    {
        EnrollmentId = 4,
        StudentId = 2,
        CourseId = 4,  // World History: Ancient Civilizations
        EnrollmentDate = new DateTime(2024, 1, 16)
    },
    new CourseEnrollment
    {
        EnrollmentId = 5,
        StudentId = 2,
        CourseId = 5,  // Shakespeare and Renaissance Literature
        EnrollmentDate = new DateTime(2024, 1, 16)
    },

    // Charlie Lee (StudentId: 3)
    new CourseEnrollment
    {
        EnrollmentId = 6,
        StudentId = 3,
        CourseId = 6,  // Linear Algebra
        EnrollmentDate = new DateTime(2024, 1, 17)
    },
    new CourseEnrollment
    {
        EnrollmentId = 7,
        StudentId = 3,
        CourseId = 7,  // Data Structures and Algorithms
        EnrollmentDate = new DateTime(2024, 1, 17)
    },

    // Diana Martinez (StudentId: 4)
    new CourseEnrollment
    {
        EnrollmentId = 8,
        StudentId = 4,
        CourseId = 8,  // Genetics
        EnrollmentDate = new DateTime(2024, 1, 18)
    },
    new CourseEnrollment
    {
        EnrollmentId = 9,
        StudentId = 4,
        CourseId = 9,  // Modern European History
        EnrollmentDate = new DateTime(2024, 1, 18)
    },
    new CourseEnrollment
    {
        EnrollmentId = 10,
        StudentId = 4,
        CourseId = 10, // Contemporary American Literature
        EnrollmentDate = new DateTime(2024, 1, 18)
    },

    // Ethan Brown (StudentId: 5)
    new CourseEnrollment
    {
        EnrollmentId = 11,
        StudentId = 5,
        CourseId = 1,  // Calculus I
        EnrollmentDate = new DateTime(2024, 1, 19)
    },
    new CourseEnrollment
    {
        EnrollmentId = 12,
        StudentId = 5,
        CourseId = 3,  // Cell Biology
        EnrollmentDate = new DateTime(2024, 1, 19)
    },

    // Fiona Garcia (StudentId: 6)
    new CourseEnrollment
    {
        EnrollmentId = 13,
        StudentId = 6,
        CourseId = 2,  // Introduction to Programming
        EnrollmentDate = new DateTime(2024, 1, 20)
    },
    new CourseEnrollment
    {
        EnrollmentId = 14,
        StudentId = 6,
        CourseId = 5,  // Shakespeare and Renaissance Literature
        EnrollmentDate = new DateTime(2024, 1, 20)
    },
    new CourseEnrollment
    {
        EnrollmentId = 15,
        StudentId = 6,
        CourseId = 7,  // Data Structures and Algorithms
        EnrollmentDate = new DateTime(2024, 1, 20)
    },

    // George Wilson (StudentId: 7)
    new CourseEnrollment
    {
        EnrollmentId = 16,
        StudentId = 7,
        CourseId = 4,  // World History: Ancient Civilizations
        EnrollmentDate = new DateTime(2024, 1, 21)
    },
    new CourseEnrollment
    {
        EnrollmentId = 17,
        StudentId = 7,
        CourseId = 6,  // Linear Algebra
        EnrollmentDate = new DateTime(2024, 1, 21)
    },

    // Hannah Davis (StudentId: 8)
    new CourseEnrollment
    {
        EnrollmentId = 18,
        StudentId = 8,
        CourseId = 8,  // Genetics
        EnrollmentDate = new DateTime(2024, 1, 22)
    },
    new CourseEnrollment
    {
        EnrollmentId = 19,
        StudentId = 8,
        CourseId = 10, // Contemporary American Literature
        EnrollmentDate = new DateTime(2024, 1, 22)
    },

    // Ian Taylor (StudentId: 9)
    new CourseEnrollment
    {
        EnrollmentId = 20,
        StudentId = 9,
        CourseId = 1,  // Calculus I
        EnrollmentDate = new DateTime(2024, 1, 23)
    },
    new CourseEnrollment
    {
        EnrollmentId = 21,
        StudentId = 9,
        CourseId = 2,  // Introduction to Programming
        EnrollmentDate = new DateTime(2024, 1, 23)
    },
    new CourseEnrollment
    {
        EnrollmentId = 22,
        StudentId = 9,
        CourseId = 9,  // Modern European History
        EnrollmentDate = new DateTime(2024, 1, 23)
    },

    // Julia Anderson (StudentId: 10)
    new CourseEnrollment
    {
        EnrollmentId = 23,
        StudentId = 10,
        CourseId = 3,  // Cell Biology
        EnrollmentDate = new DateTime(2024, 1, 24)
    },
    new CourseEnrollment
    {
        EnrollmentId = 24,
        StudentId = 10,
        CourseId = 5,  // Shakespeare and Renaissance Literature
        EnrollmentDate = new DateTime(2024, 1, 24)
    },
    new CourseEnrollment
    {
        EnrollmentId = 25,
        StudentId = 10,
        CourseId = 7,  // Data Structures and Algorithms
        EnrollmentDate = new DateTime(2024, 1, 24)
    }
};

    public static List<CourseGrade> SampleGrades = new List<CourseGrade>
{
    new CourseGrade
    {
        GradeId = 1,
        EnrollmentId = 1,
        GradeLetter = "A",
        GradePercentage = 92.5m,
        GradeDate = new DateTime(2024, 5, 15)
    },
    new CourseGrade
    {
        GradeId = 2,
        EnrollmentId = 2,
        GradeLetter = "B+",
        GradePercentage = 87.0m,
        GradeDate = new DateTime(2024, 5, 16)
    },
    new CourseGrade
    {
        GradeId = 3,
        EnrollmentId = 3,
        GradeLetter = "A-",
        GradePercentage = 90.0m,
        GradeDate = new DateTime(2024, 5, 17)
    },
    new CourseGrade
    {
        GradeId = 4,
        EnrollmentId = 4,
        GradeLetter = "B",
        GradePercentage = 85.5m,
        GradeDate = new DateTime(2024, 5, 18)
    },
    new CourseGrade
    {
        GradeId = 5,
        EnrollmentId = 5,
        GradeLetter = "A",
        GradePercentage = 94.0m,
        GradeDate = new DateTime(2024, 5, 19)
    },
    new CourseGrade
    {
        GradeId = 6,
        EnrollmentId = 6,
        GradeLetter = "B-",
        GradePercentage = 82.0m,
        GradeDate = new DateTime(2024, 5, 20)
    },
    new CourseGrade
    {
        GradeId = 7,
        EnrollmentId = 7,
        GradeLetter = "A+",
        GradePercentage = 98.0m,
        GradeDate = new DateTime(2024, 5, 21)
    },
    new CourseGrade
    {
        GradeId = 8,
        EnrollmentId = 8,
        GradeLetter = "B+",
        GradePercentage = 88.5m,
        GradeDate = new DateTime(2024, 5, 22)
    },
    new CourseGrade
    {
        GradeId = 9,
        EnrollmentId = 9,
        GradeLetter = "A-",
        GradePercentage = 91.0m,
        GradeDate = new DateTime(2024, 5, 23)
    },
    new CourseGrade
    {
        GradeId = 10,
        EnrollmentId = 10,
        GradeLetter = "B",
        GradePercentage = 84.0m,
        GradeDate = new DateTime(2024, 5, 24)
    },
    new CourseGrade
    {
        GradeId = 11,
        EnrollmentId = 11,
        GradeLetter = "A",
        GradePercentage = 93.5m,
        GradeDate = new DateTime(2024, 5, 25)
    },
    new CourseGrade
    {
        GradeId = 12,
        EnrollmentId = 12,
        GradeLetter = "B+",
        GradePercentage = 89.0m,
        GradeDate = new DateTime(2024, 5, 26)
    },
    new CourseGrade
    {
        GradeId = 13,
        EnrollmentId = 13,
        GradeLetter = "A-",
        GradePercentage = 90.5m,
        GradeDate = new DateTime(2024, 5, 27)
    },
    new CourseGrade
    {
        GradeId = 14,
        EnrollmentId = 14,
        GradeLetter = "B",
        GradePercentage = 86.0m,
        GradeDate = new DateTime(2024, 5, 28)
    },
    new CourseGrade
    {
        GradeId = 15,
        EnrollmentId = 15,
        GradeLetter = "A",
        GradePercentage = 95.0m,
        GradeDate = new DateTime(2024, 5, 29)
    },
    new CourseGrade
    {
        GradeId = 16,
        EnrollmentId = 16,
        GradeLetter = "B-",
        GradePercentage = 81.5m,
        GradeDate = new DateTime(2024, 5, 30)
    },
    new CourseGrade
    {
        GradeId = 17,
        EnrollmentId = 17,
        GradeLetter = "A+",
        GradePercentage = 97.5m,
        GradeDate = new DateTime(2024, 5, 31)
    },
    new CourseGrade
    {
        GradeId = 18,
        EnrollmentId = 18,
        GradeLetter = "B+",
        GradePercentage = 88.0m,
        GradeDate = new DateTime(2024, 6, 1)
    },
    new CourseGrade
    {
        GradeId = 19,
        EnrollmentId = 19,
        GradeLetter = "A-",
        GradePercentage = 91.5m,
        GradeDate = new DateTime(2024, 6, 2)
    },
    new CourseGrade
    {
        GradeId = 20,
        EnrollmentId = 20,
        GradeLetter = "B",
        GradePercentage = 85.0m,
        GradeDate = new DateTime(2024, 6, 3)
    }
};
}
