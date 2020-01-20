using EstudoBazorMVVM.Shared.Models;
using System.Threading.Tasks;

namespace EstudoBazorMVVM.Shared.Interfaces
{
    public interface IExcluirPessoa
    {
        Pessoa Pessoa { get; set; }
        Task ExcluirPessoa();
    }
}
