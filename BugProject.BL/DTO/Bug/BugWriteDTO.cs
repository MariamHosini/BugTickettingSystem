using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTickettingSystem.BL
{
    public class BugWriteDTO
    {
        public Guid BugId { get; set; }
        public string Description { get; set; }
        public Guid ProjectId { get; set; }
    }
}
