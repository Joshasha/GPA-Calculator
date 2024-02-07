using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GPA_CALCULATOR_TASK
{
    public class GPA_Logic
    {
        public static void Perfomance() 
        {
            double totalCourseUnitPassed = 0;
            double totalCourseUnitRegistered = 0;
            double totalStudentWeightPoints = 0;
            List<string[]> studentRecord = new List<string[]>();


            Console.WriteLine("GPA CALCULATOR");
            Console.Write("Enter Number of Registered Courses: ");
            var numberofRegisteredCourses = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberofRegisteredCourses; i++)
            {
                Console.Write("Enter Registered Course Name: ");
                string courseName = Console.ReadLine();
                Console.Write("Unit of Registered Course: ");
                int courseUnit = int.Parse(Console.ReadLine());
                Console.Write("Course Score: ");
                int courseScore = int.Parse(Console.ReadLine());

                string scoreGrade;
                if (courseScore >= 70)
                {
                    scoreGrade = "A";
                }
                else if (courseScore >= 60)
                {
                    scoreGrade = "B";
                }
                else if (courseScore >= 50)
                {
                    scoreGrade = "C";
                }
                else if (courseScore >= 45)
                {
                    scoreGrade = "D";
                }
                else if (courseScore >= 40)
                {
                    scoreGrade = "E";
                }
                else
                {
                    scoreGrade = "F";
                }

                int gradePoint;

                if (scoreGrade == "A")
                {
                    gradePoint = 5;
                }
                else if (scoreGrade == "B")
                {
                    gradePoint = 4;
                }
                else if (scoreGrade == "C")
                {
                    gradePoint = 3;
                }
                else if (scoreGrade == "D")
                {
                    gradePoint = 2;
                }
                else if (scoreGrade == "E")
                {
                    gradePoint = 1;
                }
                else
                {
                    gradePoint = 0;
                }

                int weightPointPerCourse = gradePoint * courseUnit;

                string reMark;
                if (scoreGrade == "A")
                {
                    reMark = "Excellent";
                }
                else if (scoreGrade == "B")
                {
                    reMark = "Very Good";
                }
                else if (scoreGrade == "C")
                {
                    reMark = "Good";
                }
                else if (scoreGrade == "D")
                {
                    reMark = "Pass";
                }
                else if (scoreGrade == "E")
                {
                    reMark = "Fair";
                }
                else { reMark = "Fail"; }

                

                if (scoreGrade != "F")
                {
                    totalCourseUnitPassed += courseUnit;
                }

                totalCourseUnitRegistered += courseUnit;
                totalStudentWeightPoints += weightPointPerCourse;

                string[] studentResultRecord = { courseName, courseUnit.ToString(), scoreGrade, gradePoint.ToString(), weightPointPerCourse.ToString(), reMark };


                studentRecord.Add(studentResultRecord);
                

            }



            PrintTables.PrintStudentRecords(studentRecord, totalCourseUnitRegistered, totalStudentWeightPoints, totalCourseUnitPassed);
        }

    }
}
