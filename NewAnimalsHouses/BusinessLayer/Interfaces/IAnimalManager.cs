using BusinessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer.InterfacesBL
{
    public interface IAnimalManager
    {
        IList<AnimalModel> GetAll();
    }
}
