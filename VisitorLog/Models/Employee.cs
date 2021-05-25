using System;
using System.Collections.Generic;

#nullable disable

namespace Models.VisitorLog
{
    public partial class Employee
    {
        public Employee()
        {
            Visits = new HashSet<Visit>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int IdOrganization { get; set; }

        public virtual Organization IdOrganizationNavigation { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
