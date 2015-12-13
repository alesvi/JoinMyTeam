using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoinMyTeam.Domain
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Fixture
    {
        public Guid Id { get; set; }
        public DateTime When { get; set; }
        public string Where { get; set; }
        public List<Attendee> Who { get; set; }
    }
}
