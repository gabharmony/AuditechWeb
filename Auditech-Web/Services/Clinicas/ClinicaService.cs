using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Auditech_Web.Services.Clinicas
{
    public class ClinicaService : IClinicaService
    {
        private readonly IRequest _request;
        private const string ApiUrlBase = "http://hawgamtech.somee.com/AuditechAPI/clinicas";

        public ClinicaService()
        {
            _request = new Request();
        }

        //GetClinicasAsync
        public async Task<ObservableCollection<ClinicaVirtual>> GetClinicasAsync()
        {
            ObservableCollection<ClinicaVirtual> Clinicas = await
                _request.GetAsync<ObservableCollection<ClinicaVirtual>>(ApiUrlBase);

            return Clinicas;
        }

        //GetClinicaAsync
        public async Task<ClinicaVirtual> GetClinicaAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.GetAsync<ClinicaVirtual>(ApiUrlBase + urlComplementar);
        }

        //PostClinicaAsync
        public async Task<int> PostClinicaAsync(ClinicaVirtual c)
        {
            return await _request.PostAsync(ApiUrlBase, c);
        }

        //PutClinicaAsync
        public async Task<int> PutClinicaAsync(ClinicaVirtual c)
        {
            var result = await _request.PutAsync(ApiUrlBase, c);
            return result;
        }

        //DeleteClinicaAsync
        public async Task<int> DeleteClinicaAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.DeleteAsync(ApiUrlBase + urlComplementar);
        }
    }
}