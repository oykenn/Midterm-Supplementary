using System;
using Supplementary; 

namespace Supplementary
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, Sti!");
            Address studentAddress = new Address("Aquamarine St.", "Imus", "4103");
            Address teacherAddress = new Address("Mabuhay", "Dasmarinas", "4122");

           
            Student student = new Student("Kenn Louis Mario Apellido", 20, studentAddress, 02000337239);
            Teacher teacher = new Teacher("Bernie", 45, teacherAddress, 1001, "Computrer Programming 3");


            School school = new School();

            school.IntroducePerson(student);
            school.IntroducePerson(teacher);

            student.Study();
            student.Study(" Data Structure and Algorithm");

            student.ShowCourseDetails();
            teacher.ShowCourseDetails();
        }
    }
}
