﻿namespace DAL.Models
{
   public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int HouseId { get; set; }
        public House House { get; set; }
    }
}
