namespace MyFirstProject.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Models.Customer> GetAll();
        Models.Customer? GetById(int id);
        void Create(Models.Customer customer);
        void Update(Models.Customer customer);
        void Delete(int id);
    }
}
