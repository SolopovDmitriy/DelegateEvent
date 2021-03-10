using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    delegate void CloseTaskDelegate(Task task);
    enum CloneWorkerMethod
    {
        Superficial,    //поверхностное
        Complete        //полное
    }

    /*
     * унаследоваться от класса Employee
       реализовать интерфейс IWorker
    */
   class Worker : Employee, IWorker, ICloneable, IComparable
    {
        public event CloseTaskDelegate CloseTaskEvent; //событие  закрытия task
        public List<Task> TaskList { get; set; }
        public void CloseTask(Task task) //триггер - механизм который запустит проведение экзамена
        {
            if (TaskList.Contains(task))//если в списке задач данного рабочего содержится данная задача
            {
                TaskList.Remove(task);  // то удаляет ее из списка            
                if (CloseTaskEvent != null)//если событие не пустое
                {
                   CloseTaskEvent(task);
                }
            }            
        }


        private bool _isWorking;
        private string _workDescription;

        public bool IsWorking
        {
            get
            {
                return _isWorking;
            }
        }  //поле интерфейса

        public string Work() //метод интерфейса
        {
            return _workDescription;
        }
        public void StopWorking()
        {
            _isWorking = false;
        }

        public void NextTask(string task)
        {
            if (_isWorking == false)
            {
                if (task.Length > 0)
                {
                    _workDescription = task;
                    _isWorking = true;
                }
                else
                {
                    throw new InvalidOperationException("Не понял задачу");
                }
            }
            else
            {
                throw new Exception("Я уже занят, я работаю");
            }
        }
        public Worker() : base()
        {
            _isWorking = true;
            _workDescription = "Ведутся работы по организации самой работы";
            TaskList = new List<Task>(); 
        }

        public Worker(string name, string surname, string patronimic, DateTime birthDate, Genre genre, Nationality nationality, EducationLevel education, float salary, string workDescription)
            : base(name, surname, patronimic, birthDate, genre, nationality, education, salary)
        {
            _isWorking = false;
            this.NextTask(workDescription);
            TaskList = new List<Task>();
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\n\tStatus Working: {IsWorking};" +
                $"\n\tCurrent Work: {_workDescription}";
        }

        public object Clone()
        {
            Console.WriteLine("Задействую клонирование обьекта");

            //поверхностного копирования - использовать только если нету ссылочных полей

            //полного копирования
            /*Worker worker = new Worker();
            
            worker.Name = this.Name;


            return worker;*/

            return this.MemberwiseClone(); //поверхностное копирование
        }
        public object Clone(CloneWorkerMethod method)
        {
            switch (method)
            {
                case CloneWorkerMethod.Superficial:
                    return this.Clone();
                case CloneWorkerMethod.Complete:
                    return new Worker (
                            this.Name, 
                            this.Surname, 
                            this.Patronimic, 
                            this.BirthDate, 
                            this.genre, 
                            this.nationality,
                            this.educationLevel, 
                            this.Salary, 
                            this.Work()
                   );
            }
            throw new ArgumentException("Clone Worker Method incorrect");
        }

        public int CompareTo(object obj)
        {
            //дефолтная сортировка: по имени - по ниспаданию

            Worker worker = obj as Worker;

            if(worker != null)
            {
                return worker.Name.CompareTo(this.Name); //воспользовался стандартным стринговым компарером
            }
            else
            {
                throw new Exception("Incorrect compare two walues");
            }
        }

        public void ExamenStart(string task)
        {
            Console.WriteLine($"Worker: {Name} получил задачу: {task};");
           
        }

        public void GiveSalary(Object sender, SalaryEventArg arg)
        {
            //Console.WriteLine(sender.ToString());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Доп данные: {arg.Type}; Зарплата: { arg.Salary};");
            Console.ResetColor();
        }

        public void TakeTask(Task task, Worker worker)//method TakeTask
        {
            if (this == worker)//если рабочий, который вызывает метод TakeTask совпадает с рабочим в параметрах TakeTask - TakeTask(task1, worker2);
            { 
                task.TimeTakeTask = DateTime.Now;//task.TimeTakeTask - сохраняем в свойство текущее время
                task.Status = Status.TAKE_TASK;
                TaskList.Add(task);
                Console.WriteLine($"worker {Name} take task {task.Type}");
            }
            else
            {
                Console.WriteLine($"worker {Name} ignore task {task.Type}");// не его задача (worker1, а например worker 2)
                //worker1.TakeTask(task1, worker2); // this = worker1,this-кто вызывает метод TakeTask, если worker1!=worker2, то task не его, 
                //TakeTask(task1, worker2) - передаем параметры worker2 кто должен выполнять работу task1
            }
        }


    }
}
