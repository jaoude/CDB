using AutoMapper;
using CDB.BLL.Abstraction;
using CDB.BLL.Implementation;
using CDB.Dal.DbContext;
using CDB.DAL.Abstraction.Repositories;
using CDB.DAL.Abstraction.UnitOfWork;
using CDB.DAL.Implementation.Repositories;
using CDB.DAL.Implementation.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CDB.WebApi
{
    public class Startup
    {
        // commit code branch 1
        // commit code branch 1 part 2
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();


            services.AddTransient<IBaseService, BaseService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<IDocumentService, DocumentService>();
            services.AddTransient<IShareholderService, ShareholderService>();
            services.AddTransient<IModelMapHelper, ModelMapHelper>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<IShareholderRepository, ShareholderRepository>();
            services.AddTransient<IDocumentRepository, DocumentRepository>();
            
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
