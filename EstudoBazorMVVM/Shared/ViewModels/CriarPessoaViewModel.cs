using EstudoBazorMVVM.Shared.Interfaces;
using EstudoBazorMVVM.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace EstudoBazorMVVM.Shared.ViewModels
{
    public class CriarPessoaViewModel : ICriarPessoa
    {
        private readonly HttpClient _http;
        public CriarPessoaViewModel(HttpClient http)
        {
            Console.WriteLine("Entrou no ctr CriarPessoaViewModel");
            _http = http;
        }
        private Pessoa _pessoa = new Pessoa();
        public Pessoa Pessoa 
        { 
            get => _pessoa; 
            set => _pessoa = value; 
        }

        public async Task CriarPessoa()
        {
            Console.WriteLine("Entrou no método CriarPessoa");
            var resposta = await _http.PostJsonAsync<Pessoa>("api/pessoa", _pessoa);
            Console.WriteLine($"Nova Pessoa criada:\n {resposta.Id}\n{resposta.Nome}\n{resposta.Peso}");
        }
    }
}
