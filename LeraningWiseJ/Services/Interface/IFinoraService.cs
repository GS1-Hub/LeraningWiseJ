using LeraningWiseJ.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeraningWiseJ.Services.Interface
{
    public interface IFinoraService
    {
        Task<List<Finora>> GetFinoras();
    }
}
