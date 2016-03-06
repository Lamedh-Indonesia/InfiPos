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
            var employee = (id == 0)? service.CreateNew() : employeeRepo.GetById(id);
            return employee == null ? (IHttpActionResult)NotFound() : Ok(employee);
        }

        public IHttpActionResult Post(Employee employee)
        {
            employeeRepo.Save(employee);
            return Created("/api/employee/" + employee.Id, employee);
        }

        public void Delete(int id)
        {
            employeeRepo.Delete(id);
        }
    }
}
