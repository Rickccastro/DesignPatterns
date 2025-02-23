namespace ConvertStudent.Domain;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Course { get; set; }

    public decimal Tuition { get; set; }

    public Student(int id, string name, string course, decimal tuition)
    {
        Id = id;
        Name = name;
        Course = course;
        Tuition = tuition;
    }
}
