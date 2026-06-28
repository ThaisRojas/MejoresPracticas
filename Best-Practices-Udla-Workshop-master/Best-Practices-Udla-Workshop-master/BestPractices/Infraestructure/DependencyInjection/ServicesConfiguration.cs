using Best_Practices.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Best_Practices.Infraestructure.DependencyInjection
{
    public class ServicesConfiguration
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IVehicleRepository, InMemoryVehicleRepository>();
        }
    }
}
