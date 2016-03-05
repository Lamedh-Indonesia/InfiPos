using System;
using System.Collections.Generic;
using InfiPos.Core;

namespace InfiPos.Infras.Data.InMemory
{
    public class EmployeeMemRepo : MemoryRepoBase<Employee>
    {
        public override List<Employee> Search(string key)
        {
            throw new NotImplementedException();
        }
    }
}
