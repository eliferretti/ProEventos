using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Aplication.Contratos
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model); 
        Task<Evento> UpdateEvento(Evento model);
        Task<Evento> DeleteEvento(Evento model);

        Task<Evento[]> GetAllEventosAsync(string tema, bool includePalestrantes = false);
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}
