using Biblioteka.EntityFrameworkCore;

namespace Biblioteka.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly BibliotekaDbContext _context;

        public TestDataBuilder(BibliotekaDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}