using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        //PALESTRANTES
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includePalestrantes);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includePalestrantes);
        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includePalestrantes);
    }
}
