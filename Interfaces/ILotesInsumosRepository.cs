using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plantech.Enuns;
using Plantech.Models;

namespace Plantech.Interfaces
{
    public interface ILotesInsumosRepository
    {
        Task <List<LotesInsumos>> ListarLotes();
        Task <LotesInsumos> GetLotesInsumoId(int id);
        Task  EditarLote(LotesInsumos lotesInsumo);

    }
}