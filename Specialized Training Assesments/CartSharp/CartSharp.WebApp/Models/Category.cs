namespace CartSharp.WebApp.Models
{
    public class Category
    {
        public int Id { get; set; }

        [StringLength(25)] 
        public string Name { get;set; }

        [StringLength(250)]
        public string Description { get; set; }
    }
}
