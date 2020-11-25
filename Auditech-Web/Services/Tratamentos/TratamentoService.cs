using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Auditech_Web.Services.Tratamentos
{
    public class TratamentoService : ITratamentoService
    {
        private readonly IRequest _request;
        private const string ApiUrlBase = "http://hawgamtech.somee.com/AuditechAPI/tratamentos";

        public TratamentoService()
        {
            _request = new Request();
        }

        //GetTratamentosAsync
        public async Task<ObservableCollection<Tratamento>> GetTratamentosAsync()
        {
            ObservableCollection<Tratamento> Tratamentos = await
                _request.GetAsync<ObservableCollection<Tratamento>>(ApiUrlBase);

            return Tratamentos;
        }

        //GetTratamentoAsync
        public async Task<Tratamento> GetTratamentoAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.GetAsync<Tratamento>(ApiUrlBase + urlComplementar);
        }

        //PostTratamentoAsync
        public async Task<int> PostTratamentoAsync(Tratamento t)
        {
            return await _request.PostAsync(ApiUrlBase, t);
        }

        //PutTratamentoAsync
        public async Task<int> PutTratamentoAsync(Tratamento t)
        {
            var result = await _request.PutAsync(ApiUrlBase, t);
            return result;
        }

        //DeleteTratamentoAsync
        public async Task<int> DeleteTratamentoAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.DeleteAsync(ApiUrlBase + urlComplementar);
        }
    }
}