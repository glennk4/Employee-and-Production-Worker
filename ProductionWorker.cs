using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Production_Worker
{
    class ProductionWorker : Employee
    {
        private int shiftType;
        private decimal hourlyRate;

        public ProductionWorker(string name, int number, int shiftType, decimal hourlyRate) : base(name, number)
        {
            this.shiftType = shiftType;
            this.hourlyRate = hourlyRate;
        }

        public int ShiftType 
        {
            get { return shiftType; } 
            set { shiftType = value;  }
        }

        public decimal HourlyRate 
        {
            get { return hourlyRate; } 
            set { hourlyRate = value;  }
        }

    }
}
