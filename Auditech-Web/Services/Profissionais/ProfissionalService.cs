using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Auditech_Web.Services.Profissionais
{
    public class ProfissionalService : IProfissionalService
    {
        private readonly IRequest _request;
        private const string ApiUrlBase = "http://hawgamtech.somee.com/AuditechAPI/profissionais";

        public ProfissionalService()
        {
            _request = new Request();
        }

        //GetProfissionaisAsync
        public async Task<ObservableCollection<Profissionals>> GetProfissionaisAsync()
        {
            ObservableCollection<Profissionals> Profissionais = await
                _request.GetAsync<ObservableCollection<Profissionals>>(ApiUrlBase);

            return Profissionais;
        }

        //GetProfissionalAsync
        public async Task<Profissionals> GetProfissionalAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.GetAsync<Profissionals>(ApiUrlBase + urlComplementar);
        }

        //PostProfissionalAsync
        public async Task<int> PostProfissionalAsync(Profissionals p)
        {
            return await _request.PostAsync(ApiUrlBase, p);
        }

        //PutProfissionalAsync
        public async Task<int> PutProfissionalAsync(Profissionals p)
        {
            var result = await _request.PutAsync(ApiUrlBase, p);
            return result;
        }

        //DeleteProfissionalAsync
        public async Task<int> DeleteProfissionalAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.DeleteAsync(ApiUrlBase + urlComplementar);
        }
    }
}