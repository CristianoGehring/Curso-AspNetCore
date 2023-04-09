using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository (IServiceCollection serviceColleciton)
        {
            serviceColleciton.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceColleciton.AddDbContext<MyContext>(
                options => options.UseMySql("Server=localhost;Port=3308;Database=dbApi;Uid=root;Pwd=root")
            );
        }
    }
}