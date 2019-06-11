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
		public IEnumerable<string> GetStudentDetails()
		{
			return new string[] { "Ambrish","Singh"};
		}
    }
}
