using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Auditech_Web.Services.Pacientes
{
    public class PacienteService : IPacienteService
    {
        private readonly IRequest _request;
        private const string ApiUrlBase = "http://hawgamtech.somee.com/AuditechAPI/pacientes";

        public PacienteService()
        {
            _request = new Request();
        }

        //GetPacientesAsync
        public async Task<ObservableCollection<Paciente>> GetPacientesAsync()
        {
            ObservableCollection<Paciente> Pacientes = await
                _request.GetAsync<ObservableCollection<Paciente>>(ApiUrlBase);

            return Pacientes;
        }

        //GetPacienteAsync
        public async Task<Paciente> GetPacienteAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.GetAsync<Paciente>(ApiUrlBase + urlComplementar);
        }

        //PostPacienteAsync
        public async Task<int> PostPacienteAsync(Paciente p)
        {
            return await _request.PostAsync(ApiUrlBase, p);
        }

        //PutPacienteAsync
        public async Task<int> PutPacienteAsync(Paciente p)
        {
            var result = await _request.PutAsync(ApiUrlBase, p);
            return result;
        }

        //DeletePacienteAsync
        public async Task<int> DeletePacienteAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.DeleteAsync(ApiUrlBase + urlComplementar);
        }
    }
}