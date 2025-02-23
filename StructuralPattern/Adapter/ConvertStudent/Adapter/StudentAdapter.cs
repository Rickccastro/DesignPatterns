using ConvertStudent.Adaptee;
using ConvertStudent.Domain;
using ConvertStudent.Target;

namespace ConvertStudent.Adapter;

public class StudentAdapter : ITarget
{
    private TuitionSystem tuitionSystem = new TuitionSystem();
    public void ProcessTuitionCalculator(string[,] studentArray)
    {
        string Id = null;
        string Name = null;
        string Course = null;
        string Tuition = null;

        var studentList = new List<Student>();

        for(int i = 0; i< studentArray.GetLength(0); i++)
        {
            for (int j = 0; j < studentArray.GetLength(1); j++)
            {
                if(j == 0)
                {
                    Id = studentArray[i,j];
                }
                else if(j == 1)
                {
                    Name = studentArray[i,j];
                }
                else if (j == 1)
                {
                    Course = studentArray[i,j];
                }
                else 
                {
                    Tuition = studentArray[i,j];    
                }
            }

            studentList.Add(new Student(Convert.ToInt32(Id), Name, Course, Convert.ToDecimal(Tuition)));

        }
        Console.WriteLine("The adapter has converted the array to a Student list.");

        tuitionSystem.TuitionCalculator(studentList);
    }
}
