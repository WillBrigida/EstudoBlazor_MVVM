using EstudoBazorMVVM.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstudoBazorMVVM.Shared.Interfaces
{
    public interface IPessoasViewModel
    {
        List<Pessoa> ListaPessoas { get; set; }
        Task GetListaPessoas();
        Pessoa Pessoa { get; set; }
        Task ExcluirPessoa(int id);
    }
}
