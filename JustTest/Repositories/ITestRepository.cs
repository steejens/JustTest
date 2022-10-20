using JustTest.Entities;

namespace JustTest.Repositories
{
    public interface ITestRepository
    {
        public Test GetById(int id);
        public int Create(string testName);
        public IQueryable<Test> GetAll();
    }
}
