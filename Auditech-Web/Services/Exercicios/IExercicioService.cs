using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditech_Web.Services.Exercicios
{
    public interface IExercicioService
    {
        //GET ALL
        Task<ObservableCollection<Exercicio>> GetExerciciosAsync();
        //GET
        Task<Exercicio> GetExercicioAsync(int id);
        //POST
        Task<int> PostExercicioAsync(Exercicio e);
        //PUT
        Task<int> PutExercicioAsync(Exercicio e);
        //DELETE
        Task<int> DeleteExercicioAsync(int id);
    }
}
