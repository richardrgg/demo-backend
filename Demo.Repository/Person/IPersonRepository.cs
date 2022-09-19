namespace Demo.Repository.Person
{
    public interface IPersonRepository
    {
        Task<int> Create(Model.Person person);

        Task<int> Update(Model.Person person);

        Task<int> Delete(int id);
    }
}
