namespace FleksProject.Data
{
    public class Typea
    {
        public int Id { get; set; }
        public string TypeaName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
