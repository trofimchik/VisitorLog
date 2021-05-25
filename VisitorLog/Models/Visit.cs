using System;
using System.Collections.Generic;

#nullable disable

namespace Models.VisitorLog
{
    public partial class Visit
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string DocumentNumber { get; set; }
        public int? IdEmployees { get; set; }
        public int? IdPurpose { get; set; }
        public DateTime DatetimeOfEntry { get; set; }
        public DateTime? DatetimeOfExit { get; set; }
        public string Note { get; set; }

        public virtual Employee IdEmployeesNavigation { get; set; }
        public virtual PurposesOfVisit IdPurposeNavigation { get; set; }
    }
}
