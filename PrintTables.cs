using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_CALCULATOR_TASK
{
    public class PrintTables
    {
        public static void PrintStudentRecords(List<string[]> studentRecord,double totalCourseUnitRegistered, double totalStudentWeightPoints, double totalCourseUnitPassed)
        {
            Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");
            Console.WriteLine(" | COURSE & CODE    | COURSE UNIT     | GRADE     | GRADE-UNIT    | WEIGHT PT     | REMARK       |");
            Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");

            foreach (string[] studentResultRecord in studentRecord)
            {
                Console.WriteLine($" |{studentResultRecord[0],-18}| {studentResultRecord[1],-16}|{studentResultRecord[2],-11}|{studentResultRecord[3],-15}|{studentResultRecord[4],-15}|{studentResultRecord[5],-14}|");
            }
            Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");

            double myGPA = (totalStudentWeightPoints / totalCourseUnitRegistered);

            Console.WriteLine("\n");
            Console.WriteLine($"Total course Unit Registered is {totalCourseUnitRegistered}");
            Console.WriteLine($"Total course Unit Passed is {totalCourseUnitPassed}");
            Console.WriteLine($"Total Weight Point is {totalStudentWeightPoints}");
            Console.WriteLine($"Your GPA is = {myGPA:F2}");
        }
    }
}
