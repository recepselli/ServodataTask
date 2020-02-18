using ServodataTask.Entities.Context;
using System.Threading.Tasks;
using ServodataTask.Entities.Querying;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ServodataTask.Repositories.Person
{
    public class PersonRepository : IPersonRepository
    {
        readonly AdventureWorks2014Context context;
        public PersonRepository(AdventureWorks2014Context _context)
        {
            context = _context;
        }

        public async Task<GenericPagingData<Entities.Models.Person>> GetPersons(int page, int pageSize)
        {
            var people = await context.Persons.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            var total = await context.Persons.CountAsync();

            return await Task.FromResult(new GenericPagingData<Entities.Models.Person>(total, people));
        }
    }
}