using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302223116
{
    internal class Config
    {
        public String lang {  get; set; }
        public Transfer transfer { get; set; }
        public List<String> methods { get; set; }
        public Confirmation confirmation { get; set; }
    }
}
