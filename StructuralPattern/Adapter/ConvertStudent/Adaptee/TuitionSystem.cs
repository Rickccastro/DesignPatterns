using ConvertStudent.Domain;

namespace ConvertStudent.Adaptee;

public class TuitionSystem
{
    public void TuitionCalculator(List<Student> studentList)
    {
        foreach (var student in studentList)
        {
            /*Logic to calculate a tuition price*/
            /*Example: tuition = courses * number of hours*/

            Console.WriteLine($"Aluno{student.Name} price for tuition {student.Tuition}");
        }
    }
}
