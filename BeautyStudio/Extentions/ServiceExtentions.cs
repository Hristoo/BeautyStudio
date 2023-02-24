using BeautyStudio.BL.Interfaces;
using BeautyStudio.BL.Services;
using BeautyStudio.DL.Interfaces;
using BeautyStudio.DL.Repositories.Sql;

namespace BeautyStudio.Extentions
{
    public static class ServiceExtentions
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IHairCutRepository, HairCutSqlRepository>();

            return services;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            //services.AddHostedService<Consumer<int, Order>>();
            services.AddSingleton<IHairCutService, HairCutService>();

            return services;
        }
    }
}
