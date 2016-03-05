using InfiPos.Commons;
using System;

namespace InfiPos.Core
{
    public class Employee : EntityBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; } = DateTime.Now.AddYears(-20);

        public int GetAge()
        {
            return DateTime.Now.Year - Birthdate.Year;
        }
    }
}
