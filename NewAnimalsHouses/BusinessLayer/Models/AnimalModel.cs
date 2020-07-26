namespace BusinessLayer.Models
{
    public class AnimalModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int HouseId { get; set; }
        public HouseModel House { get; set; }
    }
}
