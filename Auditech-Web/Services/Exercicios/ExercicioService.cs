using Auditech_Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Auditech_Web.Services.Exercicios
{
    public class ExercicioService : IExercicioService
    {
        private readonly IRequest _request;
        private const string ApiUrlBase = "http://hawgamtech.somee.com/AuditechAPI/exercicios";

        public ExercicioService()
        {
            _request = new Request();
        }

        //GetExerciciosAsync
        public async Task<ObservableCollection<Exercicio>> GetExerciciosAsync()
        {
            ObservableCollection<Exercicio> Exercicios = await 
                _request.GetAsync<ObservableCollection<Exercicio>>(ApiUrlBase);

            return Exercicios;
        }

        //GetExercicioAsync
        public async Task<Exercicio> GetExercicioAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.GetAsync<Exercicio>(ApiUrlBase + urlComplementar);
        }

        //PostExercicioAsync
        public async Task<int> PostExercicioAsync(Exercicio e)
        {
            return await _request.PostAsync(ApiUrlBase, e);
        }

        //PutExercicioAsync
        public async Task<int> PutExercicioAsync(Exercicio e)
        {
            var result = await _request.PutAsync(ApiUrlBase, e);
            return result;
        }

        //DeleteExercicioAsync
        public async Task<int> DeleteExercicioAsync(int id)
        {
            string urlComplementar = string.Format("/{0}", id);
            return await _request.DeleteAsync(ApiUrlBase + urlComplementar);
        }
    }
}