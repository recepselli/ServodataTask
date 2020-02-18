using ServodataTask.Entities.Querying;
using System.Threading.Tasks;

namespace ServodataTask.Repositories.Person
{
    public interface IPersonRepository
    {
        Task<GenericPagingData<Entities.Models.Person>> GetPersons(int page, int pageSize);
    }
}