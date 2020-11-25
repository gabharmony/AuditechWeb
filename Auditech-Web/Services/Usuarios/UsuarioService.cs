using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Auditech_Web.Services.Usuarios
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IRequest _request;
        private const string ApiUrlBase = "http://hawgamtech.somee.com/AuditechAPI/usuarios";

        public UsuarioService()
        {
            _request = new Request();
        }

        //GetUsuariosAsync
        public async Task<ObservableCollection<Usuario>> GetUsuariosAsync()
        {
            ObservableCollection<Usuario> Usuarios = await
                _request.GetAsync<ObservableCollection<Usuario>>(ApiUrlBase);

            return Usuarios;
        }

        //GetLoginUsuario
        public async Task<Usuario> GetLoginUsuario(string cpf, string dtNascimento)
        {
            string urlComplementar = string.Format("/login/{0}/{1}", cpf, dtNascimento);
            return await _request.GetAsync<Usuario>(ApiUrlBase + urlComplementar);
        }

        //GetUsuarioAsync
        public async Task<Usuario> GetUsuarioAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.GetAsync<Usuario>(ApiUrlBase + urlComplementar);
        }

        //PostUsuarioAsync
        public async Task<int> PostUsuarioAsync(Usuario u)
        {
            return await _request.PostAsync(ApiUrlBase, u);
        }

        //PutUsuarioAsync
        public async Task<int> PutUsuarioAsync(Usuario u)
        {
            var result = await _request.PutAsync(ApiUrlBase, u);
            return result;
        }

        //DeleteUsuarioAsync
        public async Task<int> DeleteUsuarioAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.DeleteAsync(ApiUrlBase + urlComplementar);
        }
    }
}