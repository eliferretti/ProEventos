using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist //: IGeralPersist
    {
        //PALESTRANTES
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includePalestrantes = false);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includePalestrantes = false);
        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includePalestrantes = false);
    }
}
