using System;

namespace Company
{
    public class SalaryEventArg:EventArgs
    {
        public string Type { get; set; }
        public float Salary { get; set; }

    }
}