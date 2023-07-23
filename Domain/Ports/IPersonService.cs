using Domain.Model;

namespace Domain.Ports
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetAllPeople();
        Task<Person?> GetPersonById(int id);
        Task UpdatePerson(int id, Person person);
        Task CreatePerson(Person person);
        Task DeletePerson(int id);
    }
}
