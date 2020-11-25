using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditech_Web.Services.TipoUsuarios
{
    public interface ITipoUsuarioService
    {
        //GET ALL
        Task<ObservableCollection<TipoUsuario>> GetTipoUsuariosAsync();
        //GET
        Task<TipoUsuario> GetTipoUsuarioAsync(int id);
        //POST
        Task<int> PostTipoUsuarioAsync(TipoUsuario t);
        //PUT
        Task<int> PutTipoUsuarioAsync(TipoUsuario t);
        //DELETE
        Task<int> DeleteTipoUsuarioAsync(int id);
    }
}
