using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class WorkerNameAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerNameDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerSurnameAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerSurnameDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerPatronimicAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerPatronimicDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerSalaryAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerSalaryDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)y).Salary.CompareTo(((Worker)x).Salary);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerBirthDateDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class WorkerBirthDateAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
}
