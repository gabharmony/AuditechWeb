using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditech_Web.Services.Fases
{
    public interface IFaseService
    {
        //GET ALL
        Task<ObservableCollection<Fase>> GetFasesAsync();
        //GET
        Task<Fase> GetFaseAsync(int id);
        //POST
        Task<int> PostFaseAsync(Fase f);
        //PUT
        Task<int> PutFaseAsync(Fase f);
        //DELETE
        Task<int> DeleteFaseAsync(int id);
    }
}
