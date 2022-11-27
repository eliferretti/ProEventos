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
        Task<Evento> UpdateEvento(int id, Evento model);
        Task<Evento> DeleteEvento(int eventoId);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes);
    }
}
