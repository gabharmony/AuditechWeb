using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditech_Web.Services.Pacientes
{
    public interface IPacienteService
    {
        //GET ALL
        Task<ObservableCollection<Paciente>> GetPacientesAsync();
        //GET
        Task<Paciente> GetPacienteAsync(int id);
        //POST
        Task<int> PostPacienteAsync(Paciente p);
        //PUT
        Task<int> PutPacienteAsync(Paciente p);
        //DELETE
        Task<int> DeletePacienteAsync(int id);
    }
}
