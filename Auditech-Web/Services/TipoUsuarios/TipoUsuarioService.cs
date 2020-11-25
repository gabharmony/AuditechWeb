using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Auditech_Web.Services.TipoUsuarios
{
    public class TipoUsuarioService : ITipoUsuarioService
    {
        private readonly IRequest _request;
        private const string ApiUrlBase = "http://hawgamtech.somee.com/AuditechAPI/tiposusuarios";

        public TipoUsuarioService()
        {
            _request = new Request();
        }

        //GetTipoUsuariosAsync
        public async Task<ObservableCollection<TipoUsuario>> GetTipoUsuariosAsync()
        {
            ObservableCollection<TipoUsuario> TipoUsuarios = await
                _request.GetAsync<ObservableCollection<TipoUsuario>>(ApiUrlBase);

            return TipoUsuarios;
        }

        //GetTipoUsuarioAsync
        public async Task<TipoUsuario> GetTipoUsuarioAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.GetAsync<TipoUsuario>(ApiUrlBase + urlComplementar);
        }

        //PostTipoUsuarioAsync
        public async Task<int> PostTipoUsuarioAsync(TipoUsuario t)
        {
            return await _request.PostAsync(ApiUrlBase, t);
        }

        //PutTipoUsuarioAsync
        public async Task<int> PutTipoUsuarioAsync(TipoUsuario t)
        {
            var result = await _request.PutAsync(ApiUrlBase, t);
            return result;
        }

        //DeleteTipoUsuarioAsync
        public async Task<int> DeleteTipoUsuarioAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.DeleteAsync(ApiUrlBase + urlComplementar);
        }
    }
}