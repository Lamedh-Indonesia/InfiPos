using InfiPos.Commons;
using System;

namespace InfiPos.Core
{
    public class EmployeeService : DomainServiceBase<Employee>
    {

        public EmployeeService(IEmployeeRepo employeeRepo) : base(employeeRepo)
        {
        }
        
        public override Employee CreateNew()
        {
            return new Employee { Code = GenerateCode(), };
        }

        public string GenerateCode()
        {
            return "E" + (entityRepo.GetCount() + 1);
        }
        
    }
}
