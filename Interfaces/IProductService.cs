namespace MyFirstProject.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Models.Product> GetAll();
        Models.Product? GetById(int id);
        void Create(Models.Product product);
        void Update(Models.Product product);
        void Delete(int id);
    }
}
