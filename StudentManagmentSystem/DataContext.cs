﻿namespace StudentManagmentSystem
{
    public class DataContext
    {
        List<Student> students = new List<Student>();

        public Student AddStudent(Student student)
        {

            students.Add(student);

            return student;
        }
        public void GetStudents()
        {
            foreach (Student item in students)
            {
                Console.WriteLine($"Id:{item.Id}\n Name:{item.Name}\n Age:{item.Age}\n Grade:{item.Grade}");
            }

        }
        public Student GetById(int id)
        {
            foreach (Student item in students)
            {
                if (item == null) continue;
                if (item.Id == id) return item;
                
            }
            return new Student();
        }


        public void ShowSystem()
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
        }
    }
}
