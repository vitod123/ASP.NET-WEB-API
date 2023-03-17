using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class EngineDto
    {
        public uint Id { get; set; }
        public uint TypeEngineId { get; set; } // тип мотора (TypeEngine)
        public double Horsepower { get; set; } // мощность мотора в лошадиных силах
        public double Volume { get; set; } // объем двигателя
        public uint? Cylinders { get; set; } // Число цилиндров
        public double Weight { get; set; } // Вес двигателя
        public uint FuelConsumption { get; set; } // Потребление 1 литра топлива на км
    }
}
