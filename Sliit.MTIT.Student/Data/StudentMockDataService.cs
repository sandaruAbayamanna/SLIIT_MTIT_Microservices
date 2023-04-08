namespace Sliit.MTIT.Student.Data
{
    public class StudentMockDataService
    {
        public static List<Models.Student> students = new List<Models.Student>()
        {
            new Models.Student{ Id = 1,Name="john",Address="123 Main st",Age=20},
            new Models.Student{ Id = 2,Name="Mary",Address="235 Bakers st",Age=23},
            new Models.Student{ Id = 3,Name="Sandaru",Address="126 kotta st",Age=26},
            new Models.Student{ Id = 4,Name="pulini",Address="942 nawala st",Age=21},
            new Models.Student{ Id = 5,Name="devindi",Address="627 rajagiriya st",Age=27},
        };
    }
}
