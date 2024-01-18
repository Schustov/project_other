using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FishDataGrid
{
    public class Fish
    {
        public string TypeFish { get; set; }
        public DateTime DateCatch { get; set; }
        public string ShelfLifeDays { get; set; }
        public string Weight { get; set; }

        public string ShelfLife { get; set; }


        public Fish(string typefish, DateTime datecatch, string shelflifedays, string weight, string shelflife)
        {
            TypeFish = typefish;
            DateCatch = datecatch;
            ShelfLifeDays = shelflifedays;
            Weight = weight;
            ShelfLife = shelflife;
        }
        
        public override string ToString()
        {
            return string.Format("Вид рыбы: {0}; Дата вылова: {1}; Хранение: {2}; Масса: {3}; Срок годности: {4}", TypeFish, DateCatch.ToString("dd.MM.yyyy"), ShelfLifeDays, Weight, ShelfLife);
        }
        
    }
}
