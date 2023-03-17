using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeEngine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horsepower = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<double>(type: "float", nullable: false),
                    Cylinders = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    FuelConsumption = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Makes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    MakeId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<double>(type: "float", nullable: false),
                    MaxSpeed = table.Column<double>(type: "float", nullable: false),
                    SecondSpeed = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Makes_MakeId",
                        column: x => x.MakeId,
                        principalTable: "Makes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Years_YearId",
                        column: x => x.YearId,
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "Id", "Cylinders", "FuelConsumption", "Horsepower", "TypeEngine", "Volume", "Weight" },
                values: new object[,]
                {
                    { 1, 2, 5, 60.0, "Diesel", 1.3, 220.0 },
                    { 2, 3, 6, 140.0, "Petrol", 1.5, 240.0 },
                    { 3, 4, 8, 180.0, "Petrol", 2.0, 350.0 },
                    { 4, 5, 9, 220.0, "Petrol", 2.2000000000000002, 350.0 },
                    { 5, 6, 10, 280.0, "Diesel", 2.5, 450.0 },
                    { 6, 8, 12, 370.0, "Diesel", 3.0, 700.0 },
                    { 7, 10, 14, 500.0, "Petrol", 5.0, 800.0 },
                    { 8, 12, 18, 700.0, "Petrol", 6.0, 800.0 }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Germany", "Volkswagen" },
                    { 2, "Japan", "Toyota" },
                    { 3, "Italy", "Stellantis" },
                    { 4, "Germany", "Mercedes Benz" },
                    { 5, "United States", "Ford" },
                    { 6, "United States", "General Motors" },
                    { 7, "Japan", "Honda" },
                    { 8, "United States", "Tesla" },
                    { 9, "Japan", "Nissan" },
                    { 10, "China", "BYD Co. Ltd." },
                    { 11, "Germany", "BMW" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "The most common car type is the sedan. A sedan is a four-door car type with a traditional trunk. The difference between a hatchback and a sedan is that the rear luggage compartment door does not include the rear window and the door hinges are installed under the window.", "Sedan" },
                    { 2, "A crossover is often confused with an SUV. A crossover often comes as two-wheel drive, but it can also come with 4-wheel drive. It is basically an off-road car chassis, but built more for city traffic.", "Crossover (CUV)" },
                    { 3, "Another type that climbs this list of car types is the SUV, which is becoming more and more popular. The SUV is a large car that can often carry five to seven passengers with three rows of seats. They are basically the same as a crossover, except that they are built on a body-on-frame chassis. They often have 4wd and good terrain capability.", "Sport Utility Vehicles (SUVs)" },
                    { 4, "A Hatchback car is basically a mix of a sedan and a station wagon. They often come as a 5-door set and have a hatch that opens upwards. Like the station wagon, a hatchback has door hinges above the rear window.", "Hatchback" },
                    { 5, "A wagon is quite similar to a sedan, but with an extended roofline with a hatch door instead of a trunk. Station cars are often the perfect choice for families and long car journeys due to the larger cargo space than the sedan.", "Station Wagon" },
                    { 6, "The coupe is a two-door car, very similar to the sedan but with two doors instead of four. Coupé cars often have a rear seat for two or three more passengers, but you often have to fold down one of the front seats to get there. Coupé cars are often quite more towards the sporty look.", "Coupe" },
                    { 7, "Pickup trucks have become very common in recent years. A pickup has an enclosed cab with an open cargo area. They can either have space for two passengers or four. Pickup trucks have the cabin mounted on a separate steel frame, with one exception – Honda Ridgeline.", "Pickup Truck" },
                    { 8, "The minivan or multi-purpose vehicle (MPV) is a van, but instead of cargo space, it has passenger seats. It often has 7 or 8 passenger seats, making it perfect for larger families or being used as a taxi.", "Minivan (MPV)" },
                    { 9, "A roadster car is basically a convertible car, but with two doors, and it usually has no rear seat. They are therefore good for only two people. When it comes to size, they are often very small, with limited cargo space.", "Roadster" },
                    { 10, "A Van is a two- or three-seater car model that is often used to transport goods. They often have a sealed cab from the cargo area, and they often have no windows to the cargo area, but some models have glass windows at the rear doors.", "Van" },
                    { 11, "A sports car is anything that looks sporty to you, and it can be a roadster, coupe, or even a sedan. Sports cars are quite similar to the supercar, because a supercar can also be a sports car, but the difference is often that the sports car is a step below the supercar regarding performance and price.", "Sports Cars" },
                    { 12, "The supercar is a high-performance car, usually with a very powerful and large engine. Most supercars are two-seater and at the same time very expensive – some are going for as high as one million dollars.", "Supercar" },
                    { 13, "A luxury car is exactly what it sounds like – luxury. They are often very expensive, and have all the latest features for a comfortable ride. They often have a very powerful engine, but are not very fast in curves and on racetracks. This is because they often have so many features for comfort, so they are usually very heavy.", "Luxury Cars" },
                    { 14, "The convertible or cabriolet car models come with a retractable roof. They are the perfect choice for a hot summer day when you are going on holiday to the beach. Most convertible cars have an automatic system to retrace the fabric rooftop, but on some older models, you had to do this manually. Some models even have a retractable hardtop, which makes them look like normal cars when the rooftop is closed.", "Cabriolet" },
                    { 15, "Muscle cars are cars with large muscles under the hood. Muscle cars are often older American cars with very large and powerful v8 or v10 engines, but muscle cars are also available as modern cars. Muscle cars are usually not that fast on racetracks around corners, but when they drive in a straight line, like drag racing, not many other cars can beat them.", "Muscle Cars" },
                    { 16, "The microcar or minicar is a small car that often comes with an engine size of less than a liter. They are available in various unusual designs and are ideal for city traffic due to their fuel efficiency and easy parking.", "Micro" },
                    { 17, "A camper van is often a truck chassis that has been rebuilt for camping, and they often have a kitchen, toilet, and other necessary accessories for a perfect camping trip. For example, a motorhome can also refer to a minivan that has been rebuilt for camping, such as a Volkswagen transporter.", "Camper Van" },
                    { 18, "A mini truck is exactly what it sounds like – a small truck, and it’s a mix of a pickup and a truck. They often have two or three seats and open cargo space but can also come with closed cargo space.", "Mini Truck" },
                    { 19, "A limousine is a stretched car that is often used by celebrities and pop stars. It has an elongated base and can be rebuilt from different car models.", "Limousine" },
                    { 20, "In the last place on the list, you will find the truck. Although they are not really a car type, they can come in many forms and are still a vehicle type, so we wanted to include it.", "Truck" },
                    { 21, "A hot hatch car is very similar to a hatchback car, which we talked about earlier in the article. However, a hot hatch is a hatchback that has been modified to improve performance and is generally a little more “sporty”.", "Hot Hatch" },
                    { 22, "A grand tourer is typically a high-performance luxury car designed for long-distance driving. The term “grand tourer” or just “GT” is sometimes used to describe just a high-performance sports car, but the typical grand tourer is larger and more comfortable than a sports car.", "Grand Tourer" },
                    { 23, "Utes are popular in Australia and New Zealand, where they are often used as work vehicles. Ute is short for “coupé utility” or “utility”. Ute is a regular car that has been modified with a cargo bed in the back, instead of passenger seats. This makes it perfect for carrying large objects, such as timber or building materials.", "Ute" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 24, "A military vehicle is exactly what it sounds like: a vehicle that is designed for or has been adapted to be used by the military. This includes tanks, armored personnel carriers, artillery, and other types of vehicles used by the military.", "Military Vehicle" },
                    { 25, "A dragster is built to compete in drag racing. A typical drag race is a race in a straight line from one end of a track to another, and the goal is to reach the finish line first. To achieve this, dragsters rely on their incredible speed and acceleration, which is why some dragster cars have over 8,000 horsepower.", "Dragster" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { 1, "2023" },
                    { 2, "2022" },
                    { 3, "2021" },
                    { 4, "2020" },
                    { 5, "2019" },
                    { 6, "2018" },
                    { 7, "2017" },
                    { 8, "2016" },
                    { 9, "2015" },
                    { 10, "2014" },
                    { 11, "2013" },
                    { 12, "2012" },
                    { 13, "2011" },
                    { 14, "2010" },
                    { 15, "2009" },
                    { 16, "2008" },
                    { 17, "2007" },
                    { 18, "2006" },
                    { 19, "2005" },
                    { 20, "2004" },
                    { 21, "2003" },
                    { 22, "2002" },
                    { 23, "2001" },
                    { 24, "2000" },
                    { 25, "1999" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "EngineId", "MakeId", "MaxSpeed", "Mileage", "ModelId", "Name", "Price", "SecondSpeed", "YearId" },
                values: new object[] { 1, 3, 1, 260.0, 12.0, 2, "Audi Q5", 68.013999999999996, 60.0, 2 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "EngineId", "MakeId", "MaxSpeed", "Mileage", "ModelId", "Name", "Price", "SecondSpeed", "YearId" },
                values: new object[] { 2, 7, 4, 300.0, 60.0, 6, "Mercedes-Benz CLS 63 AMG S", 62.0, 70.0, 9 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "EngineId", "MakeId", "MaxSpeed", "Mileage", "ModelId", "Name", "Price", "SecondSpeed", "YearId" },
                values: new object[] { 3, 3, 3, 220.0, 180.0, 6, "Skoda Superb 2.0 TDI 4x4", 16.0, 50.0, 7 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_EngineId",
                table: "Cars",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_MakeId",
                table: "Cars",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ModelId",
                table: "Cars",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_YearId",
                table: "Cars",
                column: "YearId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "Makes");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Years");
        }
    }
}
