using StudentInfoSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentInfoSystem.Controllers
{
    public class StudentInfoController : ApiController
    {
		public IEnumerable<StudentModel> GetStudentDetails()
		{
			List<StudentModel> listModel = new List<StudentModel>();
			StudentModel firstInfo = new StudentModel();
			firstInfo.StudentId = 1;
			firstInfo.FirstName = "A";
			firstInfo.LastName = "B";
			listModel.Add(firstInfo);

			return listModel;
		}
    }
}
