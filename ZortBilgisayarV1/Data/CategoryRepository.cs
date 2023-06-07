// using ZortBilgisayarV1.entity;

// namespace ZortBilgisayarV1.Data
// {
//     public class CategoryRepository
//     {
//         private static List<Category>? _category=null;

//         static CategoryRepository()
//         {
//             _category = new List<Category>
//             {
//                 new Category {CategoryId=1,Name="Bilgisayar",describtion="Bütün Bilgisayarlar"},
//                 new Category {CategoryId=2,Name="Tablet",describtion="Bütün Telefonlar"},
//                 new Category {CategoryId=3,Name="Telefon",describtion="Bütün Tabletler"},
//                 new Category {CategoryId=4,Name="Ekran Kartı",describtion="Bütün Ekran Kartları"},
//                 new Category {CategoryId=5,Name="İşlemci",describtion="Bütün İşlemciler"},
//                 new Category {CategoryId=6,Name="Aksesuar",describtion="Bütün Aksesuar"}
//             };
//         }

//         public static List<Category>? Categories
//         {
//             get
//             {
//                 return _category;
//             }
//         }

//         public static void AddCategory(Category category)
//         {
//             _category.Add(category);
//         }

//         public static Category GetCategoryById(int id)
//         {
//             return _category.FirstOrDefault(c=>c.CategoryId==id);
//         }
//     }
// }