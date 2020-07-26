using System.Collections.Generic;

namespace DAL.Models
{
    public class House
    {
        public House()
        {
            Animals = new List<Animal>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Animal> Animals { get; set; }
    }
}
