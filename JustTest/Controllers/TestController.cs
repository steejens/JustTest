using JustTest.Commands;
using JustTest.Queries;
using JustTest.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace JustTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly CreateTestCommand _command;
        private readonly GetTestByIdQuery _query;
        private readonly GetAllTestsQuery _all;

        public TestController(CreateTestCommand command, GetTestByIdQuery query, GetAllTestsQuery all)
        {
            _command = command;
            _query = query;
            _all = all;
        }


        [Produces("application/json")]
        [HttpPost("Create")]
        public  int CreateTest([FromQuery] string testName)
        {

            var result = _command.Create(testName);

            return result;
        }

        [Produces("application/json")]
        [HttpPost("GetById")]
        public TestResponse GetTestById([FromQuery] int id)
        {

            var result = _query.GetById(id);

            return result;
        }

        [Produces("application/json")]
        [HttpPost("All")]
        public AllTestsResponse GetAll()
        {

            var result = _all.GetAll();

            return result;
        }

    };
}