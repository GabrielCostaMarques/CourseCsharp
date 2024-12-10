using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.TaskExercicie
{
    internal class TaskModal
    {
        public string Description { get; set; }
        public bool Done { get; set; } = false;
        public int Id { get; set; }


        public TaskModal()
        {
        }

        public TaskModal(string descripton)
        {
            Description = descripton;
        }
        public TaskModal(string descripton, int id)
        {
            Description = descripton;
            Id = id;
        }


        public string Status
        {
            get
            {
                return Done ? "Concluído" : "Pendente";
            }
        }

        public string ShowOptions()
        {
            string options = "1. Adicionar tarefa  \r\n2. Marcar tarefa como concluída  \r\n3. Exibir tarefas  \r\n4. Remover tarefas concluídas ";

            Console.WriteLine(options);
            return options;
        }




        public override string ToString()
        {

            return "Tarefa #" + Id + " " + Description + " - " + Status;


        }

    }



}
