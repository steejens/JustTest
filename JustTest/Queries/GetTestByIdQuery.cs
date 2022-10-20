using JustTest.Repositories;

namespace JustTest.Queries
{
    public class GetTestByIdQuery
    {
        private readonly ITestRepository _repository;

        public GetTestByIdQuery(ITestRepository repository)
        {
            _repository = repository;
        }

        public TestResponse GetById(int id)
        {
            var result = _repository.GetById(id);
            var response = new TestResponse();
            response.Id = result.Id;
            response.TestName = result.TestName;

            return response;
        }
    }
}
