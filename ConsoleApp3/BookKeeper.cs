using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class BookKeeper : Employee, IManage
    {
        public ListOfWorkers Workers => throw new NotImplementedException();

        public EventHandler<SalaryEventArg> salaryEvent; //обобщенный делегат

        public void TakeSalary(SalaryEventArg arg)
        {
            if(salaryEvent != null)
            {
                salaryEvent(this, arg);
            }
        }

        public BookKeeper() : base()
        {

        }
        public BookKeeper(string name, string surname, string patronimic, 
                            DateTime birthDate, Genre genre, Nationality nationality, 
                                EducationLevel education,  float salary) 
            : base(name, surname, patronimic, birthDate, genre, nationality, education, salary)
        {

        }
        public void Control()
        {
            throw new NotImplementedException();
        }

        public void Organize()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
