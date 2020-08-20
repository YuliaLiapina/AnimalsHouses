using BusinessLayer.Attributes;

namespace NewAnimalsHouses.Models
{
    public class AnimalViewModel
    {
        [MyIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //public int HouseId { get; set; }
        //public HouseViewModel House { get; set; }
    }
}