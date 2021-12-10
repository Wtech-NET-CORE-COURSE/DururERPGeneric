using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Business.Concrete;
using Durur.Modules.Generic.DataAccess;
using Durur.Modules.Generic.DataAccess.Repositories;
using Durur.Modules.Generic.Entities.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Erp.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ErpGenericDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString(DbConnection.LocalConnection.ToString())));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICompanyPositionServices, CompanyPositionServices>();
            services.AddScoped<IDepartmentServices, DepartmentServices>();
            services.AddScoped<IEmployeeCompanyPositionServices, EmployeeCompanyPositionServices>();
            services.AddScoped<IEmployeeServices, EmployeeServices>();
            services.AddScoped<IJobServices, JobServices>();
            services.AddScoped<IOrderedItemServices, OrderedItemServices>();
            services.AddScoped<IOrderServices, OrderServices>();
            services.AddScoped<IOrderStatusServices, OrderStatusServices>();
            services.AddScoped<IInventoryServices, InventoryServices>();
            services.AddScoped<IProductServices, ProductServices>();
            services.AddScoped<ISupplierServices, SupplierServices>();
            services.AddScoped<IWarehouseServices, WarehouseServices>();
            services.AddScoped<ICustomerAddressServices, CustomerAddressServices>();
            services.AddScoped<ICustomerServices, CustomerServices>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ICountryServices, CountryServices>();
            services.AddScoped<ILocationServices, LocationServices>();



            services.AddTransient<Helpers.GenericHelper>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt=>opt.TokenValidationParameters=new TokenValidationParameters { 
                ValidateAudience=true,          //Token deðerini kimlerin-hangi uygulamalarýn kullanacaðýný belirler
                ValidateIssuer=true,            //Oluþturulan token deðerini kim daðýtmýþtýr
                ValidateLifetime=true,          //Oluþturulan token deðerinin yaþam süresi
                ValidateIssuerSigningKey=true,  //Üretilen token deðerinin uygulamamýza ait olup olmadýðý ile alakalý security key'i
                ValidIssuer=Configuration["Token:Issuer"],
                ValidAudience=Configuration["Token:Audience"],
                IssuerSigningKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SecurityKey"])),
                ClockSkew=TimeSpan.Zero         //Token süresinin uzatýlmasýný saðlar.
            });


            services.AddControllers();
            services.AddRazorPages();
            services.AddSwaggerDocument(s =>
            {
                s.Title = "DURUR ERP API";
            });


            //services.AddMvc().AddRazorPagesOptions(opt => opt.Conventions.AddPageRoute("/Login", ""));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });
        }
        enum DbConnection
        {
            LocalConnection,
            DefaultConnection
        }
    }
}
