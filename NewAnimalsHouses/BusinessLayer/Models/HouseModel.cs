using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public class HouseModel
    {
        public HouseModel()
        {
            Animals = new List<AnimalModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<AnimalModel> Animals { get; set; }
    }
}
