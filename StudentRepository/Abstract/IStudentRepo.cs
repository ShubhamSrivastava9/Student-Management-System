using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRepository.Models;

namespace StudentRepository.Abstract
{
    public interface IStudentRepo
    {
        List<Student> GetAllStudentData();
        string Insert_Student(Student s);
        Student GetStudentdetailOnSid(int sid);
        string Update_Student(Student s);
        string Delete_Student(int sid);
    }
}
