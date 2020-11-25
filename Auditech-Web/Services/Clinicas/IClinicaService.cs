using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditech_Web.Services.Clinicas
{
    public interface IClinicaService
    {
        //GET ALL
        Task<ObservableCollection<ClinicaVirtual>> GetClinicasAsync();
        //GET
        Task<ClinicaVirtual> GetClinicaAsync(int id);
        //POST
        Task<int> PostClinicaAsync(ClinicaVirtual c);
        //PUT
        Task<int> PutClinicaAsync(ClinicaVirtual c);
        //DELETE
        Task<int> DeleteClinicaAsync(int id);
    }
}
