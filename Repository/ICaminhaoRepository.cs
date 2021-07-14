using felipe_santos_volvoapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace felipe_santos_volvoapp.Repository
{
    public interface ICaminhaoRepository
    {
        //TODO: Adicionar os parâmetros
        Task<List<Caminhao>> GetCaminhoes();

        Task<List<Caminhao>> GetCaminhao(int id);

        Task<int?> AddCaminhao(Caminhao caminhao);

        Task<int?> DeleteCaminhao(int caminhaoId);

        Task UpdateCaminhao(Caminhao caminhao);
    }
}
