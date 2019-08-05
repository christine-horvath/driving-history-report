using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Trip
    {
        public string trip { get; set; }
        public string driver { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int distance { get; set; }
        public int timeinmins { get; set; }
        public TimeSpan diff { get; set; }
        public decimal speed { get; set; }
        public decimal mph { get; set; }
        public bool isGreater { get; set; }


        

    } 
}


