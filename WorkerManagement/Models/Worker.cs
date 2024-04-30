using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerManagement.Models
{
    public class Worker
    {
        public string Name { get; set; }
        public string DateBirth { get; set; }
        public string CPF { get; set; }
        public List<Worker> ListWorker { get; set; }

        public Worker()
        {
            ListWorker = [];
        }

        public Worker(string name, string dateBirth, string cpf)
        {
            Name = name;
            DateBirth = dateBirth;
            CPF = cpf;
        }
    }
}
