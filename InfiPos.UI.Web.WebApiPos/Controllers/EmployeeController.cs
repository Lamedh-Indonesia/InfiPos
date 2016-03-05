using InfiPos.Core;
using InfiPos.Infras.Data.EFRepos;
using System.Collections.Generic;
using System.Web.Http;

namespace InfiPos.UI.Web.WebApiPos.Controllers
{
    public class EmployeeController : ApiController
    {
        private EmployeeEFRepo employeeRepo = new EmployeeEFRepo();
        
        public List<Employee> Get()
        {
            return employeeRepo.GetAll();
        }

        public Employee Get(int id)
        {
            var service = new EmployeeService(employeeRepo);
            return (id == 0)? service.CreateNew() : employeeRepo.GetById(id);
        }
    }
}
