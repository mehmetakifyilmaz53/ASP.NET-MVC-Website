// using ZortBilgisayarV1.entity;
// namespace ZortBilgisayarV1.Data
// {
//     public class ProductRepository
//     {
//         private static List<Product>? _products=null;

//         static ProductRepository()
//         {
//             _products = new List<Product>
//             {
//                 new Product {ProductId=1,Name="Zort Minark",Price=5000, GPU="Asus Radeon RX 6650", CPU="AMD Ryzen 5 7600X", ImageUrl="pc1.jpg",describtion="Bilgisayar"},
//                 new Product {ProductId=2,Name="Zort Skye", Price=12690, GPU="Inno3D GeForce RTX 3060", CPU="AMD Ryzen 5 5500",ImageUrl="pc2.jpg", describtion="Bilgisayar"},
//                 new Product {ProductId=3,Name="Zort Freya",Price=14000, GPU="Sapphire Radeon RX 6700", CPU="AMD Ryzen 5 5600",ImageUrl="foto.jpg", describtion="Bilgisayar"},
//                 //
//                 new Product {ProductId=4,Name="Honor Pad 8", Price=5098, Camera="5 MP", Size="64 GB", ImageUrl="tablet1.jpg",  describtion="Tablet"},
//                 new Product {ProductId=5,Name="Lenovo Tab M10", Price=3799, Camera="12 MP", Size="64 GB",ImageUrl="tablet2.jpg",  describtion="Tablet"},
//                 new Product {ProductId=6 ,Name="Apple iPad 9", Price=7698, Camera="18 MP", Size="128 GB", ImageUrl="tablet3.jpg",  describtion="Tablet"},
//                 //
//                 new Product {ProductId=7,Name="iPhone 11", Price=17495, Battery="3500mAH",Camera="15 MP",Size="128 GB", ImageUrl="telefon1.jpg",  describtion="Telefon"},
//                 new Product {ProductId=8 ,Name="Redmi Note 12 Pro", Price=9875, Battery="5600mAH",Camera="43 MP",Size="256 GB", ImageUrl="iphone11.jpg", describtion="Telefon"},
//                 new Product {ProductId=9 ,Name="Omix X600", Price=4780, Battery="4000mAH",Camera="25 MP",Size="64 GB", ImageUrl="ihpne12.jpg", describtion="Telefon"},
//                 //
//                 new Product {ProductId=10,Name="Zotac GeForce RTX 4070",Price=5000,Size="12 GB", ImageUrl="ekran1.jpg", describtion="Ekran Kartı"},
//                 new Product {ProductId=11,Name="MSI GeForce RTX 4070 Gaming X",Price=5400,Size="12 GB", ImageUrl="ekran2.jpg", describtion="Ekran Kartı"},
//                 new Product {ProductId=12,Name="Asus GeForce RTX 4090 Rog Strix",Price=11000,Size="24 GB",ImageUrl="ekran3.jpg", describtion="Ekran Kartı"},
//                 //
//                 new Product {ProductId=13,Name="AMD Ryzen 5 5600",Price=4200,CPU="4.40 GHZ", ImageUrl="https://static.sinerji.gen.tr/Images/MD/KHJ-8gc-amd-tray-cpu-sinerji-pc.jpg", describtion="İşlemci"},
//                 new Product {ProductId=14,Name="AMD Ryzen 9 7900",Price=7400,CPU="3.70 GHZ", ImageUrl="https://static.sinerji.gen.tr/Images/MD/JBR-1728141-amd-ryzen-65w-9-pib-right-1260x709.jpg", describtion="İşlemci"},
//                 new Product {ProductId=15,Name="Intel Core i5 13500",Price=11000,CPU="4.80 GHZ",ImageUrl="https://static.sinerji.gen.tr/Images/MD/K8R-screenshot1.jpg", describtion="İşlemci"},
//             };
//         }

//         public static List<Product>? Products
//         {
//             get
//             {
//                 return _products;
//             }
//         }

//         public static void AddProduct(Product product)
//         {
//             _products.Add(product);
//         }

//         public static Product GetProductById(int id)
//         {
//             return _products.FirstOrDefault(p=>p.ProductId==id);
//         }

//         public static void EditProduct(Product product)
//         {
//            foreach (var p in _products)
//            {
//             if (p.ProductId == product.ProductId)
//             {
//                 p.Name= product.Name;
//                 p.Price = product.Price;
//                 p.describtion= product.describtion;
//                 p.ImageUrl= product.ImageUrl;
//                 p.Battery = product.Battery;
//                 p.Camera = product.Camera;
//                 p.CPU = product.CPU;
//                 p.GPU = product.GPU;
//             }
//            }
//         }

//         internal static void DeleteProduct(Product product)
//         {
//             foreach (var p in _products)
//            {
//             if (p.ProductId == product.ProductId)
//             {
//                 var first = ProductRepository.Products;

//                  first.Remove(p);
//                  break;
//            }
//            }
//         }
//     }
// }