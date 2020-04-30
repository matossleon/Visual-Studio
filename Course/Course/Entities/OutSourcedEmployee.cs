using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Course.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AddtionalCharge { get; set; }
        public OutSourcedEmployee()
        {

        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double addtionalCharge) : base(name, hours, valuePerHour)
        {
            AddtionalCharge = addtionalCharge;
        }
        public override double Payment()
        {
            return 1.1 * AddtionalCharge + (ValuePerHour * Hours);
        }
    }

}
