namespace StudentManagmentSystem;

public class Student
{
    public Student()
    {

    }

    public Student(int id, string name, char grade,int age)
    {
        Id = id;
        Name = name;
        Age = age;
        Grade = grade;
    }
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public char Grade { get; set; }
    
   
}
