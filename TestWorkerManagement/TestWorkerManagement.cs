using WorkerManagement.Models;
using Xunit;

namespace TestWorkerManagement
{
    public class TestWorkerManagement
    {
        private readonly Management _worker;
        

        public TestWorkerManagement()
        {
            _worker = new Management();
        }

        [Fact]
        public void RegisterWorker()
        {
            // Arrange
            var register = new Worker
            {
                Name = "test",
                CPF = "111.111.111-11",
                DateBirth = "23/02/2003"
            };

            //Act
            _worker.Register(register);

            //Assert
            Assert.NotEmpty(_worker.ListWorker);
        }

        [Fact]
        public void RemoveWorker()
        {
            // Arrange
            var register = new Worker
            {
                Name = "test",
                CPF = "111.111.111-11",
                DateBirth = "23/02/2003"
            };

            _worker.Register(register);
            // Act

            _worker.Remove(register);
            //Assert
            Assert.Empty(_worker.Workers());
        }

        [Fact]
        public void ListWorker() 
        {
            // Arrange
            _worker.Register(new Worker { });

            // Act
            var lista = _worker.Workers();

            // Assert
            Assert.NotEmpty(lista);


        }
    }
}
