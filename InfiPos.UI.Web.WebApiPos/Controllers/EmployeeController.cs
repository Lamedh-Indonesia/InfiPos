using InfiPos.Core;
using InfiPos.Infras.Data.EFRepos;
using System.Web.Http;

namespace InfiPos.UI.Web.WebApiPos.Controllers
{
    public class EmployeeController : ApiController
    {
        private EmployeeEFRepo employeeRepo = new EmployeeEFRepo();
        
        public IHttpActionResult Get(int page = 0, int size = 3)
        {
            try { return Ok(employeeRepo.GetAll(page, size)); }
            catch { return InternalServerError(); }
        }

        public IHttpActionResult Get(int id)
        {
            var service = new EmployeeService(employeeRepo);
            return Ok((id == 0)? service.CreateNew() : employeeRepo.GetById(id));
        }

        public IHttpActionResult Post(Employee employee)
        {
            employeeRepo.Save(employee);
            return Created("/api/employee/" + employee.Id, employee);
        }
    }
}
