using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.TaskExercicie
{
    internal class TaskUser


    {

        TaskModal task = new TaskModal();
        public void TaskShow()
        {
            List<TaskModal> listTask = new List<TaskModal>();

            task.ShowOptions();
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            while (option != 5)
            {
                switch (option)
                {
                    case 1:
                        Console.Write("Digite a descrição da tarefa: ");
                        string desc = Console.ReadLine();
                        int id = listTask.Count;
                        listTask.Add(new TaskModal(desc, id));

                        Console.WriteLine("");
                        Console.WriteLine("-----------------------");
                        break;

                    case 2:

                        Console.WriteLine("Digite o numero da tarefa a concluir: ");

                        int op = int.Parse(Console.ReadLine());

                        TaskModal taskComplete = listTask.Find(x => x.Id == op);

                        if (taskComplete != null)
                        {
                            taskComplete.Done = true;
                            Console.WriteLine("Tarefa concluída com sucesso!");
                        }
                        else Console.WriteLine("Tarefa nao encontrada");


                        break;

                    case 3:

                        foreach (var item in listTask)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 4:

                        listTask.RemoveAll(item =>
                        {
                            if (item.Status == "Concluído")
                            {
                                Console.WriteLine("Tarefa: " + item.Description + " Removido");
                                return true;
                            }
                            else
                            {
                                return false;
                            }

                        });



                        break;

                    case 5: break;
                }
                Console.WriteLine("");
                task.ShowOptions();
                Console.WriteLine("");
                option = int.Parse(Console.ReadLine());
            }

        }
    }
}
