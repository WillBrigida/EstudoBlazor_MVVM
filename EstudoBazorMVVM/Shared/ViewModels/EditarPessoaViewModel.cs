using EstudoBazorMVVM.Shared.Interfaces;
using EstudoBazorMVVM.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EstudoBazorMVVM.Shared.ViewModels
{
    public class EditarPessoaViewModel : IEditarPessoa
    {
        private readonly HttpClient _http;
        public EditarPessoaViewModel(HttpClient http)
        {
            Console.WriteLine("Entrou no ctr EditarPessoaViewModel");
            _http = http;
        }
        private Pessoa _pessoa = new Pessoa();
        public Pessoa Pessoa
        {
            get => _pessoa;
            set => _pessoa = value;
        }

        public async Task EditarPessoa()
        {
            Console.WriteLine("Entrou no Método EditarPessoa");
            await _http.PutJsonAsync("api/pessoa", _pessoa);
            //Console.WriteLine($"{resposta}");
        }
    }
}
