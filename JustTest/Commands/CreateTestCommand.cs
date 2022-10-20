using JustTest.Repositories;

namespace JustTest.Commands
{
    public class CreateTestCommand
    {
        private readonly ITestRepository _repository;
        public CreateTestCommand(ITestRepository repository)
        {
            _repository = repository;
        }
        public int Create(string testName)
        {
           
            var result = _repository.Create(testName);
            return result;
        }
    }
}
