using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditech_Web.Services.Tratamentos
{
    public interface ITratamentoService
    {
        //GET ALL
        Task<ObservableCollection<Tratamento>> GetTratamentosAsync();
        //GET
        Task<Tratamento> GetTratamentoAsync(int id);
        //POST
        Task<int> PostTratamentoAsync(Tratamento t);
        //PUT
        Task<int> PutTratamentoAsync(Tratamento t);
        //DELETE
        Task<int> DeleteTratamentoAsync(int id);
    }
}
