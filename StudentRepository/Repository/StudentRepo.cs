using StudentRepository.Abstract;
using StudentRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository.Repository
{
    public class StudentRepo: IStudentRepo
    {
        StudentContext sContext = new StudentContext();
        public List<Student> GetAllStudentData()
        {
            List<Student> lst = new List<Student>(); 
            lst=sContext.Students.ToList();
            sContext.SaveChanges();

            return lst;
        }
        public string Insert_Student(Student s)
        {
            string msg = string.Empty;
            try
            {
                sContext.Students.Add(s);
                sContext.SaveChanges();
                msg = "success";
            }
            catch (Exception ex)
            {
                msg = "failed";
            }
            return msg;
        }
        public Student GetStudentdetailOnSid(int sid)
        {
            Student s = sContext.Students.FirstOrDefault(m => m.SId==sid);
            return s;
        }
        public string Update_Student(Student s)
        {
            string msg= string.Empty;
            try
            {
                Student oldData=sContext.Students.FirstOrDefault(m => m.SId ==s.SId);
                
                oldData.SName=s.SName;
                oldData.Gender=s.Gender;
                oldData.Age=s.Age;
                oldData.Course=s.Course;

                sContext.SaveChanges();
                msg = "success";
            }
            catch (Exception ex) 
            {
                msg = "failed";
            }

            return msg;
        }
        public string Delete_Student(int sid) 
        {
          string msg=string.Empty;
            try
            {
                Student existingData = sContext.Students.FirstOrDefault(s => s.SId == sid);
                sContext.Students.Remove(existingData);
                sContext.SaveChanges();
                msg = "success";
            }
            catch (Exception ex)
            {
                msg = "failed";
            }
           return msg;
        }
    }
}
