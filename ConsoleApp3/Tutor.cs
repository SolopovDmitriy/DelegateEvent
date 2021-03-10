using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    //массив указателей на фенкция которая принимает строковое описание задачи
    public delegate void ExamenDelegate(string task); 

    sealed class Tutor: Employee //запечатанный класс  - запрещает наследовангие о  него
    {
        public TutorSpeciality tutorSpeciality;

        public event ExamenDelegate exemenEvent; //событие проведения экзамена

        public Tutor():base()
        {
            tutorSpeciality = TutorSpeciality.Probationer;
        }
        public Tutor(string name, string surname, string patronimic, DateTime birthDate, Genre genre, Nationality nationality, 
                                                                        EducationLevel education, float salary, TutorSpeciality tutSpec) 
            : base(name, surname, patronimic, birthDate, genre, nationality, education, salary)
        {
            tutorSpeciality = tutSpec;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n\tTutorSpeciality: {tutorSpeciality}; ";
        }

        public void Examen(string task) //триггер - механизм который запустит проведение экзамена
        {
            if(exemenEvent != null)
            {
                exemenEvent(task);
            }
        }
    }
}
