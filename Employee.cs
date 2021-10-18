using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Production_Worker
{
    class Employee
    {
        private string name;
        private int number;

        public Employee(string name, int number)
        {
           this.name = name;
           this.number = number; 
            
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public int Number
        { 
            get { return number;  }
            set { number = value;  }        
        }

    }
}
