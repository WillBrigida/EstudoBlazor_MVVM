using EstudoBazorMVVM.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstudoBazorMVVM.Shared.Interfaces
{
    public interface ICriarPessoa
    {
        Pessoa Pessoa { get; set; }
        Task CriarPessoa();

    }
}
