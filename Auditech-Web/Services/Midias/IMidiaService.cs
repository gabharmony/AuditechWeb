using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditech_Web.Services.Midias
{
    public interface IMidiaService
    {
        //GET ALL
        Task<ObservableCollection<Midia>> GetMidiasAsync();
        //GET
        Task<Midia> GetMidiaAsync(int id);
        //POST
        Task<int> PostMidiaAsync(Midia m);
        //PUT
        Task<int> PutMidiaAsync(Midia m);
        //DELETE
        Task<int> DeleteMidiaAsync(int id);
    }
}
