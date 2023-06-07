namespace ZortBilgisayarV1.entity
{
    public class Product
    {
        public int ProductId {get;set;}
        public string? Name {get;set;}
        public double? Price {get;set;}
        public string? GPU {get;set;}
        public string? CPU {get;set;}
        public string? Battery {get;set;}
        public string? Camera {get;set;}
        public string? Size {get;set;}
        public string? ImageUrl {get;set;}
        public bool IsApproved {get;set;}


        public string? describtion {get;set;}
        public List<ProductCategory>? ProductCategories {get;set;}
    }
}