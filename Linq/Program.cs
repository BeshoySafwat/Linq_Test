using Linq;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Xml.Linq;
using static Linq.Data_Base;
using static Linq.Extensions;
namespace Linq
{
    internal class Program
    {
        public static IEnumerable<Course> PageManage(int pageNumber, int pageSize)
        {
            var result=SampleCourses.Skip(pageSize *(pageNumber -1)).Take(pageSize);
            return result;
        }
       
        static void Main(string[] args)
        {
            Extensions.PrintTable(SampleInstructors);
            Console.WriteLine();
            Console.WriteLine();
            Extensions.PrintTable(SampleCourses);
            Console.WriteLine();
            Console.WriteLine();
            Extensions.PrintTable(SampleEnrollments);
            Console.WriteLine();
            Console.WriteLine();
            Extensions.PrintTable(SampleStudents);
            #region LinqBasics
            #region 1
            //var result = SampleCourses.Where(x => x.SubjectId == 1);
            //Extensions.PrintTable(result);
            #endregion
            #region 2
            //var result =SampleCourses.OrderBy(x => x.CourseStartDate);
            //Extensions.PrintTable(result);
            #endregion
            #region 3
            //var result = SampleCourses.GroupBy(x => x.Level)
            //.Select(c => new { Level = c.Key, count = c.Count() });
            //Extensions.PrintTable(result);
            #endregion
            #region 4
            //var result = SampleCourses.Join(SampleInstructors,
            //    Courses => Courses.InstructorId,
            //    instructors => instructors.InstructorId,
            //   (Courses, instructors) => new { Courses, instructors }
            //    ).Select(d => new { d.Courses.CourseId,CousreName =d.Courses.CourseName ,
            //        InstructorName= $"{d.instructors.FirstName} {d.instructors.LastName}" 
            //        , Count=SampleEnrollments.Count(x=> x.CourseId ==d.Courses.CourseId)});

            //Extensions.PrintTable(result);
            #endregion
            #region 5
            //Create a query that list all students enrolled in "Calculus I" (CourseId = 1).
            //var result = SampleEnrollments.Join(SampleStudents,
            //    Enroll => Enroll.StudentId,
            //    Students => Students.StudentId,
            //    (Students, Enroll) => new { Students,Enroll })
            //    .Where(x => x.Students.CourseId == 1)
            //    .Select(x => new { StudentName = $"{x.Enroll.FirstName} {x.Enroll.LastName}",
            //        x.Students.EnrollmentDate });
            //Extensions.PrintTable(result);
            #endregion
            #region 6
            //Find the average grade(GradePercentage) for each course.
            //Display the course name and its average grade.
            //var result = SampleEnrollments.Join(SampleGrades,
            //    Enroll => Enroll.EnrollmentId,
            //    Grades => Grades.EnrollmentId,
            //    (e, g) => new { e, g }).Join(SampleCourses,
            //    ci => ci.e.EnrollmentId,
            //    c => c.CourseId,
            //    (ci, c) => new { c, ci })
            //    .GroupBy(s => s.c.CourseName)
            //                  .Select(g => new
            //                  {
            //                      CourseName = g.Key,
            //                      AverageGrade = g.Average(x=>x.ci.g.GradePercentage)
            //                  });
            //Linq.Extensions.PrintTable(result);
            #endregion
            #region 7
            //.Find all advanced courses (Level = Advanced) that start after September 5, 2024.
            //var result = SampleCourses.Where(s => s.Level == CourseLevel.Advanced &&
            //s.CourseStartDate > new DateTime(2024, 9, 5));
            //Linq.Extensions.PrintTable(result);
            #endregion
            #region 8
            //write a query that gets all course [ course name, instructor name,
            //number of enrollment ,
            //Lowest grade , Highest Grade , Average grade] for each course.
            //var result = SampleEnrollments.Join(SampleGrades,
            //    Enroll => Enroll.EnrollmentId,
            //    Grades => Grades.EnrollmentId,
            //    (Enroll, grade) => new { Enroll, grade }).Join(SampleCourses,
            //    eg => eg.Enroll.EnrollmentId,
            //    course => course.CourseId,
            //    (eg, course) => new { course, eg }).Join(SampleInstructors,
            //    EGC=> EGC.course.InstructorId,
            //    I=> I.InstructorId,
            //    (EGC, I) => new { EGC, I})
            //    .GroupBy(s => new { s.EGC.course.CourseName,s.I.FirstName,s.I.LastName })
            //                  .Select(g => new
            //                  {
            //                      CourseName = g.Key,
            //                      InstructorName = $"{g.Key.FirstName} {g.Key.LastName}",
            //                      Count = g.Count(),
            //                      LowestGrade= g.Min(x=> x.EGC.eg.grade.GradePercentage),
            //                      MaxGrade= g.Max(x=> x.EGC.eg.grade.GradePercentage),
            //                      AverageGrade = g.Average(x => x.EGC.eg.grade.GradePercentage)
            //                  });

            //Linq.Extensions.PrintTable(result);
            #endregion
            #region 9
            //Find all students who are enrolled in both
            //a Mathematics course and a Computer Science course.
            //var result0 = SampleEnrollments.Join(SampleCourses,
            //    Enroll => Enroll.CourseId,
            //    course => course.CourseId,
            //    (Enroll, course) => new { Enroll, course }
            //    ).Join(SampleStudents,
            //    EC => EC.Enroll.StudentId,
            //    student => student.StudentId,
            //    (EC, student) => new { EC, student }
            //    ).Where(x => x.EC.course.SubjectId == 1)
            //    .Select(x => x.student);

            //var result1 = SampleEnrollments.Join(SampleCourses,
            //    Enroll => Enroll.CourseId,
            //    course => course.CourseId,
            //    (Enroll, course) => new { Enroll, course }
            //    ).Join(SampleStudents,
            //    EC => EC.Enroll.StudentId,
            //    student => student.StudentId,
            //    (EC, student) => new { EC, student }
            //    ).Where(x => x.EC.course.SubjectId == 2)
            //    .Select(x => x.student);

            //var result=result0.Intersect(result1);
            //Linq.Extensions.PrintTable(result);

            #endregion
            #region 10
            //For each subject, find the course with the highest average grade.
            //var result = SampleEnrollments.Join(SampleGrades,
            //    Enroll => Enroll.EnrollmentId,
            //    grade => grade.EnrollmentId,
            //    (Enroll, grade) => new { Enroll, grade })
            //    .Join(SampleCourses,
            //    EG => EG.Enroll.CourseId,
            //    course => course.CourseId,
            //    (EG, course) => new { EG, course })
            //    .Join(SampleSubjects,
            //    EGC => EGC.course.SubjectId,
            //    subject => subject.SubjectId,
            //    (EGC, subject) => new { EGC, subject }
            //    ).GroupBy(x => x.subject.SubjectName)
            //    .Select(g => new
            //    {
            //        Subject = g.Key,
            //        MaxAvarage = g.Max(y => y.EGC.EG.grade.GradePercentage)
            //    });
            //Linq.Extensions.PrintTable(result);
            #endregion
            #region 11
            //Write a method that takes a page number and page size as parameters
            //and returns that page of courses, ordered by CourseId.
            //(Assume page number 2 and page size 3 for this example)
            //Console.WriteLine("Enter Page Number And Page Size");
            //int num = int.Parse(Console.ReadLine());
            //int size = int.Parse(Console.ReadLine());
            //Linq.Extensions.PrintTable( PageManage(num, size));
            #endregion
            #region 12
            //write a query that gets the subject,
            //show the number of courses at each level (Beginner, Intermediate, Advanced).
            //var result = SampleSubjects.Join(SampleCourses,
            //    subject => subject.SubjectId,
            //    course => course.SubjectId,
            //    (subject, course) => new { subject, course })
            //    .GroupBy(g => g.subject.SubjectName)
            //    .Select(x => new
            //    {
            //        SubjectName = x.Key,
            //        Beginner = x.Count(b => b.course.Level == CourseLevel.Beginner),
            //        Intermediate = x.Count(b => b.course.Level == CourseLevel.Intermediate),
            //        Advanced = x.Count(b => b.course.Level == CourseLevel.Advanced)

            //    }); ;
            //Linq.Extensions.PrintTable(result);
            #endregion
            #region 13
            //var result = SampleEnrollments.Join(SampleCourses,
            //    Enroll => Enroll.CourseId,
            //    course => course.CourseId,
            //    (Enroll, course) => new { Enroll, course }
            //    ).Join(SampleStudents,
            //    EC => EC.Enroll.StudentId,
            //    student => student.StudentId,
            //    (EC, student) => new { EC, student }
            //    ).GroupBy(g=> $"{g.student.FirstName} {g.student.LastName}")
            //    .Select(x => new
            //    {
            //        StudentName = x.Key,
            //        EnrolledCourse = string.Join(", ",x.Select(n=>n.EC.course.CourseName))
            //    });

            //  🥲 دي انا غششها ياباشا مكنتش عارف
            //  left Join تتعمل ازاي بس
            //  عملت من غير null
            //  سقفه للاجتهاد
            //var result = SampleStudents.GroupJoin(SampleEnrollments,
            //                          student => student.StudentId,
            //                          enroll => enroll.StudentId,
            //                          (student, studentEnrollments) => new { student, studentEnrollments })
            //               .SelectMany(x => x.studentEnrollments.DefaultIfEmpty(),
            //                           (x, enroll) => new { x.student, enroll })
            //               .GroupJoin(SampleCourses,
            //                          se => se.enroll?.CourseId,
            //                          course => course.CourseId,
            //                          (se, courses) => new { se.student, se.enroll, courses })
            //               .SelectMany(y => y.courses.DefaultIfEmpty(),
            //                           (y, course) => new { y.student, course })
            //               .GroupBy(g => $"{g.student.FirstName} {g.student.LastName}")
            //               .Select(x => new
            //               {
            //                   StudentName = x.Key,
            //                   EnrolledCourse = string.Join(", ", x.Select(n => n.course?.CourseName ?? "No Courses Enrolled"))
            //               });

            //Linq.Extensions.PrintTable(result);
            #endregion
            #region 14
            //Group courses by both SubjectId and InstructorId,
            //then count the number of courses in each group.
            //var result = SampleCourses
            //.GroupBy(x => new { x.SubjectId, x.InstructorId })
            //.Select(g => new
            //{
            //    SubjectId = g.Key.SubjectId,
            //    InstructorId = g.Key.InstructorId,
            //    CourseCount = g.Count()
            //});

            //Linq.Extensions.PrintTable(result);
            #endregion
            #region 15
            //مش عارف ياباشا
            #endregion
            #endregion
            Extensions.PrintTable(SampleInstructors);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}