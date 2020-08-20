using DAL.Models;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IAnimalRepository
    {
        IList<Animal> GetAll();
    }
}
