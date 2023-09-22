using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar
{
    public class User
    {
        public int week { get; set; }
        public DateTime semesterDate { get; set; }
        public List<TheModules> modules { get; set; }
    }
}
