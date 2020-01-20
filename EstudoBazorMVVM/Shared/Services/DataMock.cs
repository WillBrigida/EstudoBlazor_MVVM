using EstudoBazorMVVM.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstudoBazorMVVM.Shared.Services
{
    public class DataMock
    {
        public static async Task<List<Pessoa>> GetListaProdutos()
        {

            List<Pessoa> list = new List<Pessoa>
            {
               new Pessoa {Id = 1, Nome = "Will", Peso = 115},
               new Pessoa {Id = 2, Nome = "Duda", Peso = 60},
               new Pessoa {Id = 3, Nome = "Arthur", Peso = 22},
            };
            await Task.Delay(3000);
            return await Task.Run(() =>
            {
                return list;
            });
        }
    }
}
