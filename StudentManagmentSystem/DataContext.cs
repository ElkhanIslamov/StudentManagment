namespace StudentManagmentSystem
{
    public class DataContext
    {
        List<Student> students = new List<Student>();       
         
        public Student AddStudent(Student student)
        {
            foreach (Student item in students)
            {
                students.Add(item);
            }
            return student;
        }
        public Student GetStudents(Student student)
        {
            foreach(Student item in students)
            {
                Console.WriteLine($"Id:{item.Id} Name:{item.Name} Age:{item.Age} Grade:{item.Grade}");
            }            
                return student;                      
        }
        public Student DeleteStudents(Student student)
        {
            foreach (Student item in students)
            {
                students.Remove(item);
            }
            return student;
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
