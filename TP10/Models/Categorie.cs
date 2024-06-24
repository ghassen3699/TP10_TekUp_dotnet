namespace TP10.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public List<SousCategorie> SousCategories { get; set; } = new List<SousCategorie>();
    }
}
