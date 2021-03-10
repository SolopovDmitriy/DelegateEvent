using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    delegate int Operation(int a, int b);

    class Program
    {
        static int sum(int x, int y)
        {
            return x + y;
        }

        static void TestDelegate()
        {
            int x = 10;
            Operation oper = sum;

            Console.WriteLine(oper(2,5)); // 7       operSum do the same as sum
            Console.WriteLine(sum(2,5)); // 7
        }

        static void TakeTask1(Task task, Worker worker)
        {
            Console.WriteLine("version1 ");
        }

        static void TakeTask2(Task task, Worker worker)
        {
            Console.WriteLine("version2 hello");
        }


        static void TestTask()
        {
            Task task1 = new Task("drova");//create task
            Task task2 = new Task("fish");
            Manager manager1 = new Manager{ Name = "Jhon" };//manager1.Name="Jhon"; Manager manager1 = new Manager(){ Name = "Jhon" };

            manager1.TaskList.Add(task1);
            manager1.TaskList.Add(task2);
            Worker worker1 = new Worker { Name = "Alex"};
            Worker worker2 = new Worker { Name = "Petr" };
            Worker worker3 = new Worker { Name = "Nick" };
            //Console.WriteLine(task2.Type);
            //Console.WriteLine(task2.Status);
            //TakeTaskDelegate takeTask = TakeTask2;            
            ////takeTask = null;
            //takeTask(task1, worker1) ;
            //TakeTask2(task1, worker1);


            worker1.CloseTaskEvent += manager1.CloseTask;//manager1 подписался на событие CloseTaskEvent (cобытие закрытия task ),
            //worker1.CloseTaskEvent - у первого рабочего.
            worker2.CloseTaskEvent += manager1.CloseTask;
            worker3.CloseTaskEvent += manager1.CloseTask;

            



            manager1.TakeTaskEvent += worker1.TakeTask; // worker1 подписался на событие.
            manager1.TakeTaskEvent += worker2.TakeTask;
            manager1.TakeTaskEvent += worker3.TakeTask;
            //manager1.TakeTaskEvent += TakeTask1; // for example


            manager1.GiveTask(task1, worker1);//метод GiveTask вызывает TakeTaskEvent, который равен 
            //группе методов [worker1.TakeTask, worker2.TakeTask,worker3.TakeTask,]

            worker1.CloseTask(task1);

            //worker1.TakeTask(task1, worker2); // this = worker1,this-кто вызывает метод TakeTask, если worker1!=worker2, то task не его, 
            //TakeTask(task1, worker2) - передаем параметры worker2 кто должен выполнять работу task1

        }




        static void Main(string[] args)
        {
            // TestDelegate();
            TestTask();

            /*Human human = new Human();
            Console.WriteLine(human);
            Console.WriteLine(human.ToString());
            Console.WriteLine(human.genre);
            Console.WriteLine(human.nationality);
            Console.WriteLine(human.Name); //поле: чтение
            human.Name = "Вася";           //поле: запись
            Console.WriteLine(human.Name); 
            Console.WriteLine(human.getName());*/

            try
            {
                //класс абстрактный - нет возможности создать его экземпляр
                //Human human = new Human("Марко", "Поло", "Иммануилович", new DateTime(1775, 10, 25), Genre.MALE, Nationality.English);
                //Employee employee = new Employee();
                //Console.WriteLine(employee);

                /*Tutor tutor = new Tutor();
                Console.WriteLine(tutor);
                tutor.Show();

                Tutor tutor_two = new Tutor("Марко", "Поло", "Иммануилович", new DateTime(1990, 10, 25), Genre.MALE, Nationality.English, 
                                        EducationLevel.Higher, 3500f, TutorSpeciality.Biologist);

                Console.WriteLine(tutor_two);


                Worker worker = new Worker("Марко", "Поло", "Иммануилович", new DateTime(1990, 10, 25), Genre.MALE, Nationality.English,
                                        EducationLevel.Higher, 3500f, "Колоть дрова");

                if (!worker.IsWorking)
                {
                    worker.NextTask("Выпить кофе");
                }
                worker.StopWorking();
                worker.NextTask("Покурить");
                Console.WriteLine(worker.Work());
                worker.StopWorking();
                worker.NextTask("Колоть дрова");
                Console.WriteLine(worker.Work());

                
                Manager manager = new Manager();
                manager.addWorker(worker);
                */
                /*Random random = new Random();
                ListOfWorkers listOfWorkers = new ListOfWorkers();
                for (int i = 0; i < 25; i++)
                {
                    listOfWorkers.AddWorker(
                        new Worker (
                            "worker_" + i,
                            "tested",
                            "tested",
                            DateTime.Now,
                            Genre.UNDEFINED,
                            Nationality.Argentine,
                            EducationLevel.Higher,
                            random.Next(2500, 5500)
                            ,
                            "чтото делает и слава богу")
                    );
                }*/

                /*for (int i = listOfWorkers.Count - 1; i >= 0; i--)
                {
                    listOfWorkers.RemoveWorker(listOfWorkers.Workers[i]);
                }*/

                /*for (int i = 0; i < 25; i++)
                {
                    listOfWorkers.RemoveWorker(listOfWorkers.Workers[0]);
                }*/

                /*Console.WriteLine(listOfWorkers);

                Console.WriteLine(listOfWorkers.Count);
                Console.WriteLine(listOfWorkers.Workers.Length);


                Point2D point2D = new Point2D();
                Console.WriteLine(++point2D);
                    //point2D++;
                    //++point2D;
                Console.WriteLine(point2D);
                Console.WriteLine(-point2D);
                Console.WriteLine(point2D);

                Console.WriteLine(point2D + new Point2D(15,45));

                Console.WriteLine(point2D + 15);
                Console.WriteLine(45 + point2D);

                Point2D point2D1 = new Point2D(15,15);
                Point2D point2D2 = new Point2D(15,10);

                Console.WriteLine(point2D1);
                Console.WriteLine(point2D2);

                Console.WriteLine(point2D1.Equals(point2D2));


                if (!point2D1)
                {
                    Console.WriteLine("точка в положительном пространстве");
                }
                else
                {
                    Console.WriteLine("точка в отрицательном пространстве");
                }


                listOfWorkers[5] = new Worker();
                Console.WriteLine(((Worker)listOfWorkers[5]).Name); //по индексу


                Console.WriteLine(((Worker)listOfWorkers[listOfWorkers.Workers[5]]).Name); //через ссылку на обьект
                listOfWorkers[listOfWorkers.Workers[6]] = new Worker();
                Console.WriteLine(((Worker)listOfWorkers[listOfWorkers.Workers[6]]));
                */




                /*int[] arr = new int[25];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(0, 10);
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();

                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                /**IEnumerable возвращает GetEnumerator()
                 
                    IEnumerator 
                        : MoveNext()
                        : object Current {get; }
                        : void Reset()
                 */

                /*Console.WriteLine("Через IEnumerator: ");
                IEnumerator ieArr = arr.GetEnumerator();
                while (ieArr.MoveNext())
                {
                    int item = (int)ieArr.Current;
                    Console.Write(item + " ");
                }
                ieArr.Reset();


                foreach (Worker item in listOfWorkers)
                {
                    Console.WriteLine(item);
                }


                Worker worker_1 =
                    new Worker("Макс", "", "", DateTime.Now, Genre.MALE, Nationality.Argentine, EducationLevel.Higher, 2500f, "работаю");

                Worker worker_2 = worker_1; //ссылка

                worker_2.Name = "Максимилиан";
                Console.WriteLine(worker_1.Name);
                Console.WriteLine(worker_2.Name);


                /*ICloneable - чтобы обьект смог создавать копию самого себя*/

                /* Worker worker_3 = (Worker)worker_1.Clone();
                 worker_3.Name = "Новое имяяяя";
                 Console.WriteLine(worker_3);


                 Worker worker_4 = (Worker)worker_3.Clone(CloneWorkerMethod.Complete);
                 worker_4.Name = "Маклауд";

                 Console.WriteLine(worker_4.Name);
                 Console.WriteLine(worker_3.Name);


                 /*задействуется стандартная сортировка - default - по возрастанию
                     int string
                     IComparable

                     int CompareTo(Object 0){
                         < 0 текущее знаяение идет первым - левее от сравниваемого
                         > 0 текущее значение идет вторым - после сравниваемого
                         == 0 значит что значения равны
                     }
                  */


                /*используется стандартная сортировка - но переопределенная нами -- наоборот - по ниспаданию*/
                /*Array.Sort(listOfWorkers.Workers);
                foreach (Worker worker in listOfWorkers.Workers)
                {
                    Console.WriteLine(worker);
                }*/


                /*Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("сортировка по зарплате: ");

                IWorker[] tmp = listOfWorkers.Workers;
                Array.Sort(tmp, new WorkerSalaryDescComparer());

                foreach (Worker worker in tmp)
                {
                    Console.WriteLine(worker);
                }
                Console.ResetColor();*/


                /*object ob = 45; //boxind
                int number = (int)ob; //unboxing

                Point3D<int> point3Dint = new Point3D<int>();
                Console.WriteLine(point3Dint);
                Point3D<decimal> point3Ddec = new Point3D<decimal>(0.0005m, 0.0003m, 0.0001m);
                Console.WriteLine(point3Ddec);


                MyTwoParameters<Guid, Worker> myTwoParameters = new MyTwoParameters<Guid, Worker>();
                myTwoParameters.Key = Guid.NewGuid();
                myTwoParameters.Value = 
                    new Worker(
                        "Макс", 
                        "Бесспоров", 
                        "Иннокентиевич", 
                        DateTime.Now, 
                        Genre.MALE, 
                        Nationality.Argentine, 
                        EducationLevel.Higher, 
                        2500f, 
                        "работаю"
                   );
                Console.WriteLine(myTwoParameters);

                CalcInt calcInt = new CalcInt(15);
                Console.WriteLine(calcInt);

                calcInt = calcInt.Div(new CalcInt(90), new CalcInt(45));

                Console.WriteLine(calcInt);
                */


                //обобщенный тип - параметризированную коллекцию
                //boxing - unboxing - низкая производительность + безопасности типов
                //ArrayList - List<>
                //HashTable - Dictionary<key, value>
                //SortedList - SortedList<>

                /*ArrayList employeers = new ArrayList();
                employeers.Add(new Tutor());
                employeers.Add(new Worker());
                employeers.Add(new Worker());
                employeers.Add(new Tutor());
                employeers.Add(new Manager());

                Console.WriteLine(employeers.Count); //кол элементов в списке
                Console.WriteLine(employeers.Capacity); //

                foreach (var item in employeers)
                {
                    if(item is Tutor)
                    {
                        Console.WriteLine(((Tutor)item));
                    }else if (item is Manager)
                    {
                        Console.WriteLine(((Manager)item));
                    }
                    else if (item is Worker)
                    {
                        Console.WriteLine(((Worker)item));
                    }
                }*/

                /*List<Worker> workerslist = new List<Worker>();
                workerslist.Add(new Manager());
                workerslist.Add(new Tutor());
                workerslist.Add(new Worker());*/


                //List<Worker>
                //заполнить
                //отобразить
                //отсортировать
                //отобразить отсортированные

                //CalcInt calcInt = new CalcInt(15);

                ////Делегат - массив указателей на функцию
                //CalcDelegate calcDelegate = new CalcDelegate(calcInt.Multy);
                //Console.WriteLine(calcDelegate(calcInt)); //15 * 15 = 225

                //calcDelegate += calcInt.Div;
                //calcDelegate += calcInt.Sum;
                //calcDelegate += calcInt.Substr;

                //foreach (CalcDelegate item in calcDelegate.GetInvocationList())
                //{
                //    Console.WriteLine(item(calcInt));
                //}
                //CalcDelegate<CalcInt> calcDelegateCalcInt = new CalcDelegate<CalcInt>(calcInt.Div);
                //Console.WriteLine(calcDelegateCalcInt(new CalcInt(75), new CalcInt(25)));





                //Tutor tutor = new Tutor();

                //List<Worker> listOfWorkers = new List<Worker>();
                //listOfWorkers.Add(new Worker("Марко", "Поло", "Иммануилович", new DateTime(1990, 10, 25), Genre.MALE, Nationality.English,
                //                        EducationLevel.Higher, 3500f, "Колоть дрова"));
                //listOfWorkers.Add(new Worker("Максим", "Брюнов", "Иванович", new DateTime(1990, 10, 25), Genre.MALE, Nationality.English,
                //                        EducationLevel.Higher, 3500f, "Носить дрова"));
                //listOfWorkers.Add(new Worker("Инна", "Маркова", "Саммуиловна", new DateTime(1990, 10, 25), Genre.FEMALE, Nationality.English,
                //                        EducationLevel.Higher, 3500f, "Колоть дрова"));


                //Console.WriteLine("Сессия началась :)");
                //tutor.exemenEvent += listOfWorkers[0].ExamenStart;
                //tutor.Examen($"Принести скромному и самому лучшему учителю 1500$");
               
                //tutor.exemenEvent-= listOfWorkers[0].ExamenStart; //экономим марко 200$

                //foreach (var item in listOfWorkers)
                //{
                //    tutor.exemenEvent += item.ExamenStart;
                //}

                //tutor.Examen("Сдать на развитие факультета далкие 200$");







                //BookKeeper bookKeeper = new BookKeeper();

                //bookKeeper.salaryEvent += listOfWorkers[0].GiveSalary;

                //bookKeeper.TakeSalary(new SalaryEventArg { Type = "Зарплата", Salary = 5600f });

                //bookKeeper.salaryEvent -= listOfWorkers[0].GiveSalary;

                //Console.WriteLine("Сотрудники подписались на получение зарплаты");
                ///*foreach (var item in listOfWorkers)
                //{
                //    bookKeeper.salaryEvent += item.GiveSalary;
                //}*/


                //Random random = new Random();
                //Console.WriteLine("Сотрудники получили зарплату: ");
                //foreach (var item in listOfWorkers)
                //{
                //    bookKeeper.TakeSalary(new SalaryEventArg { Type = "Аванс", Salary = (float)Math.Floor(random.NextDouble() * 1000) });
                //}


            }

            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Я ошибка, но программа не вылетела :)");
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            Console.WriteLine("Я программа и я все одно работаю :)");
            Console.ReadKey();
        }
      
    }
   
}
