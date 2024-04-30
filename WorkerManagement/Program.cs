using WorkerManagement.Models;

namespace WorkerManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Management m = new Management();
            Worker worker = new Worker
            {
                Name = "Test 1",
                CPF = "111.111.111-22",
                DateBirth = "11/11/2000",
            };

            m.Register(worker);

            Worker f1 = new()
            {
                Name = "Test 2",
                CPF = "222.222.222-33",
                DateBirth = "444.444.444-55"
            };

            m.Register(f1);
            m.Workers();
            m.Remove(worker);
            Console.WriteLine("Workers after remove Test 1");
            Console.WriteLine("");
            m.Workers();

            Console.ReadLine();


        }
    }
}
