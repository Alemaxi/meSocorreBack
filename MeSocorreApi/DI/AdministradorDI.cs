using AdministradorApplication.Implementations;
using AdministradorBusiness.Implementation;
using Domain.Administrador.Application;
using Domain.Administrador.Business;
using Domain.core.Repository;
using MySqlInfrastructure.Repository;

namespace MeSocorreApi.DI
{
    public class AdministradorDI
    {
        public AdministradorDI(IServiceCollection services)
        {
            services.AddScoped<IEspecialidadeApplication,EspecialidadeApplication>();
            services.AddScoped<IEspecialidadeBusiness, EspecialidadeBusiness>();
            services.AddScoped<IEspecialidadeRepository, EspecialidadeRepository>();
        }
    }
}
