using Sliit.MTIT.Student.Data;
using Sliit.MTIT.Student.Models;

namespace Sliit.MTIT.Student.Services
{
    public class StudentService:IStudentService
    {
        public List<Models.Student> GetStudents() 
        {
            return StudentMockDataService.students;
        }

        public Models.Student GetStudent(int id)
        {
            return StudentMockDataService.students.FirstOrDefault(x => x.Id == id);
        }
        public Models.Student? AddStudent(Models.Student student)
        {
            StudentMockDataService.students.Add(student); 
            return student;
        }

        public Models.Student? UpdateStudent(Models.Student student)
        {
            Models.Student selectedStudent = StudentMockDataService.students.FirstOrDefault(x => x.Id == student.Id);
            if(selectedStudent != null)
            {
                selectedStudent.Address = student.Address;
                selectedStudent.Age = student.Age;
                selectedStudent.Name =student.Name;
                return selectedStudent;

            }
            return selectedStudent;
        }

        public bool? DeleteStudent(int id) {
            Models.Student selectedStudent = StudentMockDataService.students.FirstOrDefault(x => x.Id == id);
            if(selectedStudent != null)
            {
                StudentMockDataService.students.Remove(selectedStudent);
                return true;
            }
            return false;

        }
    }
}
