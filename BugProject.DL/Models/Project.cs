﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTickettingSystem.DAL
{
    public class Project
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public ICollection<Bug>? Bugs { get; set; }


    }
}
