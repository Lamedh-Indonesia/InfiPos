namespace InfiPos.Core
{
    public class EmployeeService
    {
        private IEmployeeRepo employeeRepo;

        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        public Employee CreateNew()
        {
            return new Employee { Code = GenerateCode(), };
        }

        public string GenerateCode()
        {
            return "E" + (employeeRepo.GetCount() + 1);
        }

        public void Save(Employee employee)
        {
            employeeRepo.Save(employee);
        }
    }
}
