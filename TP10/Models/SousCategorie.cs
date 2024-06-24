namespace TP10.Models
{
    public class SousCategorie
    {
       public int ID { get; set; }
            public string? Name { get; set; }
        public List<Categorie> Categories { get; set; } = new List<Categorie>();
        

    }
}
