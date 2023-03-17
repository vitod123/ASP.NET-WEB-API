using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Infrastructure.Data
{
    public static class DbContextExtensions
    {
        public static void SeedCars(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(new[]
            {
                new Car()
                {
                    Id = 1,
                    Name = "Audi Q5",
                    YearId = 2,
                    Price = 68.014,
                    MakeId = 1,
                    ModelId = 2,
                    EngineId = 3,
                    Mileage = 12.000,
                    MaxSpeed = 260,
                    SecondSpeed = 60,
                },

                new Car()
                {
                    Id = 2,
                    Name = "Mercedes-Benz CLS 63 AMG S",
                    YearId = 9,
                    Price = 62.000,
                    MakeId = 4,
                    ModelId = 6,
                    EngineId = 7,
                    Mileage = 60.000,
                    MaxSpeed = 300,
                    SecondSpeed = 70,

                },
                new Car()
                {
                    Id = 3,
                    Name = "Skoda Superb 2.0 TDI 4x4",
                    YearId = 7,
                    Price = 16.000,
                    MakeId = 3,
                    ModelId = 6,
                    EngineId = 3,
                    Mileage = 180.000,
                    MaxSpeed = 220,
                    SecondSpeed = 50,
                },
            });
        }

        public static void SeedEngines(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Engine>().HasData(new[]
            {
                new Engine()
                {
                    Id = 1,
                    TypeEngine = "Diesel",
                    Horsepower = 60,
                    Volume = 1.3,
                    Cylinders = 2,
                    Weight = 220,
                    FuelConsumption = 5,
                },
                new Engine()
                {
                    Id = 2,
                    TypeEngine = "Petrol",
                    Horsepower = 140,
                    Volume = 1.5,
                    Cylinders = 3,
                    Weight = 240,
                    FuelConsumption = 6,
                },
                new Engine()
                {
                    Id = 3,
                    TypeEngine = "Petrol",
                    Horsepower = 180,
                    Volume = 2.0,
                    Cylinders = 4,
                    Weight = 350,
                    FuelConsumption = 8,
                },
                new Engine()
                {
                    Id = 4,
                    TypeEngine = "Petrol",
                    Horsepower = 220,
                    Volume = 2.2,
                    Cylinders = 5,
                    Weight = 350,
                    FuelConsumption = 9,
                },
                new Engine()
                {
                    Id = 5,
                    TypeEngine = "Diesel",
                    Horsepower = 280,
                    Volume = 2.5,
                    Cylinders = 6,
                    Weight = 450,
                    FuelConsumption = 10,
                },
                new Engine()
                {
                    Id = 6,
                    TypeEngine = "Diesel",
                    Horsepower = 370,
                    Volume = 3.0,
                    Cylinders = 8,
                    Weight = 700,
                    FuelConsumption = 12,
                },
                new Engine()
                {
                    Id = 7,
                    TypeEngine = "Petrol",
                    Horsepower = 500,
                    Volume = 5.0,
                    Cylinders = 10,
                    Weight = 800,
                    FuelConsumption = 14,
                },
                new Engine()
                {
                    Id = 8,
                    TypeEngine = "Petrol",
                    Horsepower = 700,
                    Volume = 6.0,
                    Cylinders = 12,
                    Weight = 800,
                    FuelConsumption = 18,
                },
            });
        }

        public static void SeedMakes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Make>().HasData(new[]
            {
                new Make()
                {
                    Id = 1,
                    Name = "Volkswagen",
                    Country = "Germany"
                },
                new Make()
                {
                    Id = 2,
                    Name = "Toyota",
                    Country = "Japan"
                },
                new Make()
                {
                    Id = 3,
                    Name = "Stellantis",
                    Country = "Italy"
                },
                new Make()
                {
                    Id = 4,
                    Name = "Mercedes Benz",
                    Country = "Germany"
                },
                new Make()
                {
                    Id = 5,
                    Name = "Ford",
                    Country = "United States"
                },
                new Make()
                {
                    Id = 6,
                    Name = "General Motors",
                    Country = "United States"
                },
                new Make()
                {
                    Id = 7,
                    Name = "Honda",
                    Country = "Japan"
                },
                new Make()
                {
                    Id = 8,
                    Name = "Tesla",
                    Country = "United States"
                },
                new Make()
                {
                    Id = 9,
                    Name = "Nissan",
                    Country = "Japan"
                },
                new Make()
                {
                    Id = 10,
                    Name = "BYD Co. Ltd.",
                    Country = "China"
                },
                new Make()
                {
                    Id = 11,
                    Name = "BMW",
                    Country = "Germany"
                },

            });
        }

        public static void SeedModels(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model>().HasData(new[]
            {
                new Model()
                {
                    Id = 1,
                    Name = "Sedan",
                    Description = "The most common car type is the sedan. A sedan is a four-door car type with a traditional trunk. The difference between a hatchback and a sedan is that the rear luggage compartment door does not include the rear window and the door hinges are installed under the window.",
                },
                new Model()
                {
                    Id = 2,
                    Name = "Crossover (CUV)",
                    Description = "A crossover is often confused with an SUV. A crossover often comes as two-wheel drive, but it can also come with 4-wheel drive. It is basically an off-road car chassis, but built more for city traffic.",
                },
                new Model()
                {
                    Id = 3,
                    Name = "Sport Utility Vehicles (SUVs)",
                    Description = "Another type that climbs this list of car types is the SUV, which is becoming more and more popular. The SUV is a large car that can often carry five to seven passengers with three rows of seats. They are basically the same as a crossover, except that they are built on a body-on-frame chassis. They often have 4wd and good terrain capability.",
                },
                new Model()
                {
                    Id = 4,
                    Name = "Hatchback",
                    Description = "A Hatchback car is basically a mix of a sedan and a station wagon. They often come as a 5-door set and have a hatch that opens upwards. Like the station wagon, a hatchback has door hinges above the rear window.",
                },
                new Model()
                {
                    Id = 5,
                    Name = "Station Wagon",
                    Description = "A wagon is quite similar to a sedan, but with an extended roofline with a hatch door instead of a trunk. Station cars are often the perfect choice for families and long car journeys due to the larger cargo space than the sedan.",
                },
                new Model()
                {
                    Id = 6,
                    Name = "Coupe",
                    Description = "The coupe is a two-door car, very similar to the sedan but with two doors instead of four. Coupé cars often have a rear seat for two or three more passengers, but you often have to fold down one of the front seats to get there. Coupé cars are often quite more towards the sporty look.",
                },
                new Model()
                {
                    Id = 7,
                    Name = "Pickup Truck",
                    Description = "Pickup trucks have become very common in recent years. A pickup has an enclosed cab with an open cargo area. They can either have space for two passengers or four. Pickup trucks have the cabin mounted on a separate steel frame, with one exception – Honda Ridgeline.",
                },
                new Model()
                {
                    Id = 8,
                    Name = "Minivan (MPV)",
                    Description = "The minivan or multi-purpose vehicle (MPV) is a van, but instead of cargo space, it has passenger seats. It often has 7 or 8 passenger seats, making it perfect for larger families or being used as a taxi.",
                },
                new Model()
                {
                    Id = 9,
                    Name = "Roadster",
                    Description = "A roadster car is basically a convertible car, but with two doors, and it usually has no rear seat. They are therefore good for only two people. When it comes to size, they are often very small, with limited cargo space.",
                },
                new Model()
                {
                    Id = 10,
                    Name = "Van",
                    Description = "A Van is a two- or three-seater car model that is often used to transport goods. They often have a sealed cab from the cargo area, and they often have no windows to the cargo area, but some models have glass windows at the rear doors.",
                },
                new Model()
                {
                    Id = 11,
                    Name = "Sports Cars",
                    Description = "A sports car is anything that looks sporty to you, and it can be a roadster, coupe, or even a sedan. Sports cars are quite similar to the supercar, because a supercar can also be a sports car, but the difference is often that the sports car is a step below the supercar regarding performance and price.",
                },
                new Model()
                {
                    Id = 12,
                    Name = "Supercar",
                    Description = "The supercar is a high-performance car, usually with a very powerful and large engine. Most supercars are two-seater and at the same time very expensive – some are going for as high as one million dollars.",
                },
                new Model()
                {
                    Id = 13,
                    Name = "Luxury Cars",
                    Description = "A luxury car is exactly what it sounds like – luxury. They are often very expensive, and have all the latest features for a comfortable ride. They often have a very powerful engine, but are not very fast in curves and on racetracks. This is because they often have so many features for comfort, so they are usually very heavy.",
                },
                new Model()
                {
                    Id = 14,
                    Name = "Cabriolet",
                    Description = "The convertible or cabriolet car models come with a retractable roof. They are the perfect choice for a hot summer day when you are going on holiday to the beach. Most convertible cars have an automatic system to retrace the fabric rooftop, but on some older models, you had to do this manually. Some models even have a retractable hardtop, which makes them look like normal cars when the rooftop is closed.",
                },
                new Model()
                {
                    Id = 15,
                    Name = "Muscle Cars",
                    Description = "Muscle cars are cars with large muscles under the hood. Muscle cars are often older American cars with very large and powerful v8 or v10 engines, but muscle cars are also available as modern cars. Muscle cars are usually not that fast on racetracks around corners, but when they drive in a straight line, like drag racing, not many other cars can beat them.",
                },
                new Model()
                {
                    Id = 16,
                    Name = "Micro",
                    Description = "The microcar or minicar is a small car that often comes with an engine size of less than a liter. They are available in various unusual designs and are ideal for city traffic due to their fuel efficiency and easy parking.",
                },
                new Model()
                {
                    Id = 17,
                    Name = "Camper Van",
                    Description = "A camper van is often a truck chassis that has been rebuilt for camping, and they often have a kitchen, toilet, and other necessary accessories for a perfect camping trip. For example, a motorhome can also refer to a minivan that has been rebuilt for camping, such as a Volkswagen transporter.",
                },
                new Model()
                {
                    Id = 18,
                    Name = "Mini Truck",
                    Description = "A mini truck is exactly what it sounds like – a small truck, and it’s a mix of a pickup and a truck. They often have two or three seats and open cargo space but can also come with closed cargo space.",
                },
                new Model()
                {
                    Id = 19,
                    Name = "Limousine",
                    Description = "A limousine is a stretched car that is often used by celebrities and pop stars. It has an elongated base and can be rebuilt from different car models.",
                },
                new Model()
                {
                    Id = 20,
                    Name = "Truck",
                    Description = "In the last place on the list, you will find the truck. Although they are not really a car type, they can come in many forms and are still a vehicle type, so we wanted to include it.",
                },
                new Model()
                {
                    Id = 21,
                    Name = "Hot Hatch",
                    Description = "A hot hatch car is very similar to a hatchback car, which we talked about earlier in the article. However, a hot hatch is a hatchback that has been modified to improve performance and is generally a little more “sporty”.",
                },
                new Model()
                {
                    Id = 22,
                    Name = "Grand Tourer",
                    Description = "A grand tourer is typically a high-performance luxury car designed for long-distance driving. The term “grand tourer” or just “GT” is sometimes used to describe just a high-performance sports car, but the typical grand tourer is larger and more comfortable than a sports car.",
                },
                new Model()
                {
                    Id = 23,
                    Name = "Ute",
                    Description = "Utes are popular in Australia and New Zealand, where they are often used as work vehicles. Ute is short for “coupé utility” or “utility”. Ute is a regular car that has been modified with a cargo bed in the back, instead of passenger seats. This makes it perfect for carrying large objects, such as timber or building materials.",
                },
                new Model()
                {
                    Id = 24,
                    Name = "Military Vehicle",
                    Description = "A military vehicle is exactly what it sounds like: a vehicle that is designed for or has been adapted to be used by the military. This includes tanks, armored personnel carriers, artillery, and other types of vehicles used by the military.",
                },
                new Model()
                {
                    Id = 25,
                    Name = "Dragster",
                    Description = "A dragster is built to compete in drag racing. A typical drag race is a race in a straight line from one end of a track to another, and the goal is to reach the finish line first. To achieve this, dragsters rely on their incredible speed and acceleration, which is why some dragster cars have over 8,000 horsepower.",
                },
            });
        }

        public static void SeedYears(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Year>().HasData(new[]
            {
                new Year()
                {
                    Id = 1,
                    Date = "2023"
                },
                new Year()
                {
                    Id = 2,
                    Date = "2022"
                },
                new Year()
                {
                    Id = 3,
                    Date = "2021"
                },
                new Year()
                {
                    Id = 4,
                    Date = "2020"
                },
                new Year()
                {
                    Id = 5,
                    Date = "2019"
                },
                new Year()
                {
                    Id = 6,
                    Date = "2018"
                },
                new Year()
                {
                    Id = 7,
                    Date = "2017"
                },
                new Year()
                {
                    Id = 8,
                    Date = "2016"
                },
                new Year()
                {
                    Id = 9,
                    Date = "2015"
                },
                new Year()
                {
                    Id = 10,
                    Date = "2014"
                },
                new Year()
                {
                    Id = 11,
                    Date = "2013"
                },
                new Year()
                {
                    Id = 12,
                    Date = "2012"
                },
                new Year()
                {
                    Id = 13,
                    Date = "2011"
                },
                new Year()
                {
                    Id = 14,
                    Date = "2010"
                },
                new Year()
                {
                    Id = 15,
                    Date = "2009"
                },
                new Year()
                {
                    Id = 16,
                    Date = "2008"
                },
                new Year()
                {
                    Id = 17,
                    Date = "2007"
                },
                new Year()
                {
                    Id = 18,
                    Date = "2006"
                },
                new Year()
                {
                    Id = 19,
                    Date = "2005"
                },
                new Year()
                {
                    Id = 20,
                    Date = "2004"
                },
                new Year()
                {
                    Id = 21,
                    Date = "2003"
                },
                new Year()
                {
                    Id = 22,
                    Date = "2002"
                },
                new Year()
                {
                    Id = 23,
                    Date = "2001"
                },
                new Year()
                {
                    Id = 24,
                    Date = "2000"
                },
                new Year()
                {
                    Id = 25,
                    Date = "1999"
                },
            });
        }
    }
}