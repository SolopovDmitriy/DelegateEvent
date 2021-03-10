using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
 delegate void TakeTaskDelegate(Task task, Worker worker);

    class Manager : Employee, IManage
    {
        public event TakeTaskDelegate TakeTaskEvent; //событие  передачи задания

        public List<Task> TaskList { get; set; }

        public void GiveTask(Task task, Worker worker) //триггер - механизм который запустит проведение экзамена
        {
            if (TakeTaskEvent != null)
            {
                TakeTaskEvent(task, worker);
            }
        }

        public void CloseTask(Task task)
        { 
            Console.WriteLine($"Manager {Name} get message from worker about closetask {task.Type}");
            task.Status = Status.CLOSE_TASK;
            task.TimeCloseTask = DateTime.Now;           
        }


        private ListOfWorkers _workers; //список рабочих текущего экземпляра менеджера
        public ListOfWorkers Workers { //поле получения доступа к рабочим текущего менеджера
            get
            {
                return _workers;
            }
        }
        
        public IWorker GetWorker(int index)
        {
            throw new NotImplementedException(); //заглушка
        }
        public IWorker GetWorker(string workDescription)
        {
            throw new NotImplementedException(); //заглушка
        }
        public void PushWork(string task, IWorker[] workers)
        {

        }
        public Manager()
        {
            _workers = new ListOfWorkers();
            TaskList = new List<Task>();
        }

















        public void Control()
        {
            throw new NotImplementedException();
        }

        public void Organize()
        {
            throw new NotImplementedException();
        }
    }
}
