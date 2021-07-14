using felipe_santos_volvoapp.Data;
using felipe_santos_volvoapp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace felipe_santos_volvoapp.Repository
{

    //Repository design pattern para encapsular a logica de acesso para banco de dados
    public class CaminhaoRepository: ICaminhaoRepository
    {
        FelipeAppContext db;
        public CaminhaoRepository(FelipeAppContext _db)
        {
            db = _db;
        }

        public async Task<List<Caminhao>> GetCaminhoes()
        {
            if (db != null)
            {
                return await db.Caminhao.ToListAsync();
            }
            return null;
        }

        public async Task<List<Caminhao>> GetCaminhao(int id)
        {
            //TODO
            return null;
        }

        public async Task<int?> AddCaminhao(Caminhao caminhao)
        {
            if (db != null)
            {
                await db.Caminhao.AddAsync(caminhao);
                await db.SaveChangesAsync();

                return caminhao.Id;
            }
            return 0;
        }

        public async Task<int?> DeleteCaminhao(int caminhaoId)
        {
            int result = 0;

            if (db != null)
            {
                //Encontrar caminhao por meio do ID
                var caminhao = await db.Caminhao.FirstOrDefaultAsync(x => x.Id == caminhaoId);

                if (caminhao != null)
                {
                    //Deletar caminhao
                    db.Caminhao.Remove(caminhao);

                    //Commitar transacao
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public async Task UpdateCaminhao(Caminhao caminhao)
        {
            if (db != null)
            {
                //Deletar caminhao
                db.Caminhao.Update(caminhao);

                //Commitar transacao
                await db.SaveChangesAsync();
            }
        }
    }
}
