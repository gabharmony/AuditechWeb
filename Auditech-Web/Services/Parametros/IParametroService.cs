using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditech_Web.Services.Parametros
{
    public interface IParametroService
    {
        //GET ALL
        Task<ObservableCollection<Parametro>> GetParametrosAsync();
        //GET
        Task<Parametro> GetParametroAsync(int id);
        //POST
        Task<int> PostParametroAsync(Parametro p);
        //PUT
        Task<int> PutParametroAsync(Parametro p);
        //DELETE
        Task<int> DeleteParametroAsync(int id);
    }
}
