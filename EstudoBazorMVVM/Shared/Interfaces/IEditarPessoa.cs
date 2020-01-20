using EstudoBazorMVVM.Shared.Models;
using System.Threading.Tasks;

namespace EstudoBazorMVVM.Shared.Interfaces
{
    public interface IEditarPessoa
    {
        Pessoa Pessoa { get; set; } 
        Task EditarPessoa();
    }
}
