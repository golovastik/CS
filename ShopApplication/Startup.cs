using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ShopApplication.Data.interfaces;
using ShopApplication.Data.mocks;

namespace ShopApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllBooks, MockBook>();   //иноерефейс реализуется в MockBook
            services.AddTransient<IBooksCategory, MockCategory>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();    //страница с ошибками
            app.UseStatusCodePages();   //коды страниц (404)
            app.UseStaticFiles();   //css, контент
            app.UseMvcWithDefaultRoute();   //отследивает url адрес и если нет контроллера и вида то используется url по умолчанию

        }
    }
}
