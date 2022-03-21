namespace WpfApp14
{
    public enum Categorys
    {
        Food,
        Applaince
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public Categorys Categorys { get; set; }
        
    }
}