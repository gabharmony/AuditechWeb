using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Auditech_Web.Services.Fases
{
    public class FaseService : IFaseService
    {
        private readonly IRequest _request;
        private const string ApiUrlBase = "http://hawgamtech.somee.com/AuditechAPI/fases";

        public FaseService()
        {
            _request = new Request();
        }

        //GetFasesAsync
        public async Task<ObservableCollection<Fase>> GetFasesAsync()
        {
            ObservableCollection<Fase> Fases = await
                _request.GetAsync<ObservableCollection<Fase>>(ApiUrlBase);

            return Fases;
        }

        //GetFaseAsync
        public async Task<Fase> GetFaseAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.GetAsync<Fase>(ApiUrlBase + urlComplementar);
        }

        //PostFaseAsync
        public async Task<int> PostFaseAsync(Fase f)
        {
            return await _request.PostAsync(ApiUrlBase, f);
        }

        //PutFaseAsync
        public async Task<int> PutFaseAsync(Fase f)
        {
            var result = await _request.PutAsync(ApiUrlBase, f);
            return result;
        }

        //DeleteFaseAsync
        public async Task<int> DeleteFaseAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.DeleteAsync(ApiUrlBase + urlComplementar);
        }
    }
}