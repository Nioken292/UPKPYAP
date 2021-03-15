using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLab1
{
    public class Factory
    {
        string Name { get; set; }
        string Adress { get; set; }
        int Year { get; set; }
        public Factory(string Name,string Adress,int Year)
        {
            this.Name = Name;
            this.Adress = Adress;
            this.Year = Year;
        }
    }
}
