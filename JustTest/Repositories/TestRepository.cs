using JustTest.Entities;
using System.Linq;

namespace JustTest.Repositories
{
    public class TestRepository:ITestRepository
    {
        private readonly AppDbContext _context;
        public TestRepository(AppDbContext context)
        {
            _context = context;
        }
        public Test GetById(int id)
        {
            var result = _context.Test.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public int Create(string testName)
        { 
            _context.Test.Add(new Test
            {
                TestName = testName
            });
            _context.SaveChanges();
            return _context.Test.Count();
        }

        public IQueryable<Test> GetAll()
        {
            var result = _context.Test?.AsQueryable();
            return result;
        }
    }
}
