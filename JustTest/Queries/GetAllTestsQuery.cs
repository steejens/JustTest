using JustTest.Repositories;

namespace JustTest.Queries
{
    public class GetAllTestsQuery
    {
        private readonly ITestRepository _repository;

        public GetAllTestsQuery(ITestRepository repository)
        {
            _repository = repository;
        }

        public AllTestsResponse GetAll()
        {
            var result = _repository.GetAll().ToList();
            
            var items = result.Select(test => new TestResponse() { Id = test.Id, TestName = test.TestName }).ToList();


            return new AllTestsResponse()
            {
                Responses = items,
            };
        }
    }
}
