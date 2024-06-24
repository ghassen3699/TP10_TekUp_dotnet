using TP10.Models;

namespace TP10.Repositories
{
    public interface ICategoryInterface
    {
        Task<IEnumerable<Categorie>> GetAllCategories();
        Task<Categorie> CreateCategory(Categorie category);
        Task<Categorie> EditCategory(int id, Categorie
       category);
        Task<Categorie> DeleteCategory(int id);

    }
}
