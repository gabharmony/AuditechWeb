using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auditech_Web.Models;

namespace Auditech_Web.Services.Profissionais
{
    public interface IProfissionalService
    {
        Task<ObservableCollection<Profissionals>> GetProfissionaisAsync();
        Task<Profissionals> GetProfissionalAsync(int id);
        Task<int> PostProfissionalAsync(Profissionals p);
        Task<int> PutProfissionalAsync(Profissionals p);
        Task<int> DeleteProfissionalAsync(int id);
    }
}
