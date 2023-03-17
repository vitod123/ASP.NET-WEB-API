using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class CarDto
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public int YearId { get; set; }
        public double Price { get; set; }
        public uint MakeId { get; set; }          // Производитель (Make)
        public uint ModelId { get; set; }         // Модель (Model)
        public uint EngineId { get; set; }        // Мотор (Engine)
        public double Mileage { get; set; }      // Пробег
        public double MaxSpeed { get; set; }     // Скорость
        public double SecondSpeed { get; set; }  // Скорость за 1 секунду
        public MakeDto? Make { get; set; }
        public ModelDto? Model { get; set; }
        public EngineDto? Engine { get; set; }
        public YearDto? Year { get; set; }
    }
}
