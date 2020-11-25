using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditech_Web.Services.Usuarios
{
    public interface IUsuarioService
    {
        //GET ALL
        Task<ObservableCollection<Usuario>> GetUsuariosAsync();
        //GET
        Task<Usuario> GetUsuarioAsync(int id);
        //GET Login
        Task<Usuario> GetLoginUsuario(string cpf, string dtnascimento);
        //POST
        Task<int> PostUsuarioAsync(Usuario u);
        //PUT
        Task<int> PutUsuarioAsync(Usuario u);
        //DELETE
        Task<int> DeleteUsuarioAsync(int id);
    }
}
