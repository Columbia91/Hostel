using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel
{
    class Program
    {
        const int MIN_SALARY = 20000;
        static void Main(string[] args)
        {
            Student first = new Student("Ben Hunter", "E122", 4.5, 36000, Gender.Male, EducationForm.Internal);
            Student second = new Student("Tom Teddy", "T212", 4.0, 28000, Gender.Male, EducationForm.Internal);
            Student third = new Student("Vicky Fox", "D105", 4.55, 45000, Gender.Female, EducationForm.Internal);
            Student[] students = new Student[]
            {
                first, second, third
            };
        }
        static void GetHostel(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                 
            }
        }
    }
}/*Общежитие в первую очередь предоставляется тем, у кого доход на члена семьи меньше 
двух минимальных зарплат, 
затем остальным в порядке уменьшения среднего балла. 
Вывести список очередности предоставления мест в общежитии.*/
