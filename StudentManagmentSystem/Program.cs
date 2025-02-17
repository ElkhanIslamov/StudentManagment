using Microsoft.VisualBasic;

namespace StudentManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataContext dataContext = new DataContext();
            List<Student> students = new List<Student>();

            //switch (commandNumber)
            //{
            //    case 1:
            //  string exit = Console.ReadLine();   
            do
            {
                Console.WriteLine("Student managment system");
                Console.WriteLine(new string('-', 50));
                dataContext.ShowSystem();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine(new string('-', 50));
                Console.Write("Choose an option:");
                int command = int.Parse(Console.ReadLine());
                if (command == 1)
                {
                    Console.WriteLine("Add a new student");
                    Console.WriteLine(new string('-', 50));
                    Console.Write("Add id : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Add name : ");
                    string name = Console.ReadLine();
                    Console.Write("Add age : ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Add grade : ");
                    char grade = char.Parse(Console.ReadLine());
                    var student = new Student();
                    {
                        student.Id = id;
                        student.Name = name;
                        student.Age = age;
                        student.Grade = grade;
                    }
                    dataContext.AddStudent(student);
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Student succesfully added");
                    //break;
                }
                else if (command == 2)
                {
                    dataContext.GetStudents();
                    
                   
                 
                }
                else if (command == 4)
                {
                    var student = new Student();
                    dataContext.DeleteStudents(student);
                }

            } while (true);
        }
    }
}

