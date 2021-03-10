using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
   public class Task// создали задачу
    {
        
        public string Type//property
        {
            get;set;
        }
        public Status Status
        {
            get; set;
        }

        public DateTime TimeTakeTask{ get; set; }

        public DateTime TimeCloseTask { get; set; }

        public Task(string type)//constructor
        {
            Type = type;
            Status = Status.CREATED_TASK;           
        }


    }
}
