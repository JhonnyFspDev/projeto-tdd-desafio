using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerManagement.Models
{
    public class Management
    {
        public List<Worker> ListWorker { get; set; }
        public Management()
        {
            ListWorker = new List<Worker>();
        }
        public void Register(Worker worker)
        {
            ListWorker.Add(worker);
        }

        public List<Worker> Remove(Worker worker)
        {
            ListWorker.Remove(worker);

            return ListWorker;
        }
        public List<Worker> Workers()
        {
            foreach (var worker in ListWorker)
            {
                Console.WriteLine(worker.Name);
                Console.WriteLine(worker.DateBirth);
                Console.WriteLine(worker.CPF);
                Console.WriteLine("----------------------");
            }

            return ListWorker;
        }
    }
}
