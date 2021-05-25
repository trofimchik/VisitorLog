using System;
using System.Collections.Generic;

#nullable disable

namespace Models.VisitorLog
{
    public partial class PurposesOfVisit
    {
        public PurposesOfVisit()
        {
            Visits = new HashSet<Visit>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
