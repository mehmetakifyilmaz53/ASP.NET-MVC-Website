namespace ZortBilgisayarV1.entity
{
    public class Category
    {
        public int CategoryId {get;set;}
        public string? Name {get;set;}
        public string? describtion {get;set;}
        public string? Gidis {get;set;}
        public List<ProductCategory>? ProductCategories{get;set;}
    }
}