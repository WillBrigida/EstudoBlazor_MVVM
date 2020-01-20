using EstudoBazorMVVM.Shared.Interfaces;
using EstudoBazorMVVM.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;



namespace EstudoBazorMVVM.Shared.ViewModels
{
    public class PessoasViewModel : IPessoasViewModel
    {
        private HttpClient _http;
        public PessoasViewModel(HttpClient html)
        {
            _http = html;
        }
        private List<Pessoa> _listaPessoas;
        public List<Pessoa> ListaPessoas
        {
            get => _listaPessoas;
            set => _listaPessoas = value;
        }

        private Pessoa _pessoa = new Pessoa();
        public Pessoa Pessoa 
        { 
            get => _pessoa; 
            set => _pessoa = value;
        }

        public async Task GetListaPessoas()
        {
            System.Console.WriteLine("Entrou no método GetListaProdutos");
            
            _listaPessoas = await _http.GetJsonAsync<List<Pessoa>>("api/pessoa");
            _listaPessoas.ForEach(x => System.Console.WriteLine($"{x.Nome}  {x.Peso}"));
        }

        public async Task ExcluirPessoa(int id)
        {
            await _http.DeleteAsync($"api/pessoa/{id}");
            await GetListaPessoas();
        }
    }
}
