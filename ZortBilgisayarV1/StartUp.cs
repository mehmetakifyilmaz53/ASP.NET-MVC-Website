using ZortBilgisayarV1.business.Abstract;
using ZortBilgisayarV1.business.Concrete;
using ZortBilgisayarV1.data.Abstract;
using ZortBilgisayarV1.data.Concrete.SQL.EFCore;

namespace ZortBilgisayar
{
    public class StartUp
    {
        public void ConfigureServices (IServiceCollection services)
        {
            services.AddScoped<IProductRepository, EFCoreProductRepository>();
            services.AddScoped<ICategoryRepository, EFCoreCategoryRepository>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {

            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                SeedDatabe.Seed();
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); //site içerisinde yönlendirme kullanılıcağını belirten kod

            app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=home}/{action=index}/{id?}" //= ile varsayılan bir değer vermeye default routing denir
                    );
                });
        }
    }
}