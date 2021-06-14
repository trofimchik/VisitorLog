using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorLog.Models.SubModels
{
    class CurrentVisitor
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string DocumentNumber { get; set; }
        public string EmpSurname { get; set; }
        public string EmpName { get; set; }
        public string EmpPatronymic { get; set; }
        public string OrgName { get; set; }
        public string Purpose { get; set; }
        public DateTime DateTimeOfEntry { get; set; }
        public string Note { get; set; }

    }
}
