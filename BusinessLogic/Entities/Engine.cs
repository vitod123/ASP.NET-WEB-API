namespace Core.Entities
{
    public class Engine
    {
        public int Id { get; set; }
        public string TypeEngine { get; set; } //Type of engine
        public double Horsepower { get; set; } // мощность мотора в лошадиных силах
        public double Volume { get; set; } // объем двигателя
        public int? Cylinders { get; set; } // Число цилиндров
        public double Weight { get; set; } // Вес двигателя
        public int FuelConsumption { get; set; } // Потребление 1 литра топлива на км
        public ICollection<Car> Cars { get; set; }
    }
}