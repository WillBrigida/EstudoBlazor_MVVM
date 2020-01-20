using EstudoBazorMVVM.Shared.Interfaces;
using EstudoBazorMVVM.Shared.ViewModels;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace EstudoBazorMVVM.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPessoasViewModel, PessoasViewModel>();
            services.AddTransient<ICriarPessoa, CriarPessoaViewModel>();
            services.AddTransient<IEditarPessoa, EditarPessoaViewModel>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
