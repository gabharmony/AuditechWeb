using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Auditech_Web.Services.Midias
{
    public class MidiaService : IMidiaService
    {
        private readonly IRequest _request;
        private const string ApiUrlBase = "http://hawgamtech.somee.com/AuditechAPI/midias";

        public MidiaService()
        {
            _request = new Request();
        }

        //GetMidiasAsync
        public async Task<ObservableCollection<Midia>> GetMidiasAsync()
        {
            ObservableCollection<Midia> Midias = await
                _request.GetAsync<ObservableCollection<Midia>>(ApiUrlBase);

            return Midias;
        }

        //GetMidiaAsync
        public async Task<Midia> GetMidiaAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.GetAsync<Midia>(ApiUrlBase + urlComplementar);
        }

        //PostMidiaAsync
        public async Task<int> PostMidiaAsync(Midia m)
        {
            return await _request.PostAsync(ApiUrlBase, m);
        }

        //PutMidiaAsync
        public async Task<int> PutMidiaAsync(Midia m)
        {
            var result = await _request.PutAsync(ApiUrlBase, m);
            return result;
        }

        //DeleteMidiaAsync
        public async Task<int> DeleteMidiaAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.DeleteAsync(ApiUrlBase + urlComplementar);
        }
    }
}