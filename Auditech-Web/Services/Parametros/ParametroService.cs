using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Auditech_Web.Services.Parametros
{
    public class ParametroService : IParametroService
    {
        private readonly IRequest _request;
        private const string ApiUrlBase = "http://hawgamtech.somee.com/AuditechAPI/parametros";

        public ParametroService()
        {
            _request = new Request();
        }

        //GetParametrosAsync
        public async Task<ObservableCollection<Parametro>> GetParametrosAsync()
        {
            ObservableCollection<Parametro> Parametros = await
                _request.GetAsync<ObservableCollection<Parametro>>(ApiUrlBase);

            return Parametros;
        }

        //GetParametroAsync
        public async Task<Parametro> GetParametroAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.GetAsync<Parametro>(ApiUrlBase + urlComplementar);
        }

        //PostParametroAsync
        public async Task<int> PostParametroAsync(Parametro p)
        {
            return await _request.PostAsync(ApiUrlBase, p);
        }

        //PutParametroAsync
        public async Task<int> PutParametroAsync(Parametro p)
        {
            var result = await _request.PutAsync(ApiUrlBase, p);
            return result;
        }

        //DeleteParametroAsync
        public async Task<int> DeleteParametroAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.DeleteAsync(ApiUrlBase + urlComplementar);
        }
    }
}