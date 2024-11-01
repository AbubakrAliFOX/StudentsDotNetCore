using StudentsAPI.Model;


namespace StudentsAPI.DataSimulation
{
    public class StudentsDataSimulation
    {
        public static readonly List<Student> StudentsList = new List<Student>
        {
            new Student {ID =  1, Name = "Khaled", Age = 22, Grade = 90},
            new Student {ID =  2, Name = "Ahmad", Age = 25, Grade = 23},
            new Student {ID =  3, Name = "Mohammad", Age = 26, Grade = 62},
            new Student {ID =  4, Name = "Abdullah", Age = 23, Grade = 77},
            new Student {ID =  5, Name = "Malsef", Age = 21, Grade = 60}
        };
    }
}
