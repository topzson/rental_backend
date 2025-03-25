using rentalApi.Models;

namespace rentalApi.Data
{
    public static class VehiclesData
    {
        public static List<Vehicles> VehiclesList = new List<Vehicles>
        {
            new Vehicles
            {
                ID = 1,
                licensePlate = "ABC123",
                brand = "Toyota",
                model = "Corolla",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-10),
                    endDate = DateTime.Now.AddDays(10),
                    id = 101,
                    customerName = "John Doe"
                }
            },
            new Vehicles
            {
                ID = 2,
                licensePlate = "XYZ789",
                brand = "Honda",
                model = "Civic",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-5),
                    endDate = DateTime.Now.AddDays(15),
                    id = 102,
                    customerName = "Jane Smith"
                }
            },
            new Vehicles
            {
                ID = 3,
                licensePlate = "DEF456",
                brand = "Ford",
                model = "Focus",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-15),
                    endDate = DateTime.Now.AddDays(5),
                    id = 103,
                    customerName = "Robert Johnson"
                }
            },
            new Vehicles
            {
                ID = 4,
                licensePlate = "GHI789",
                brand = "Nissan",
                model = "Altima",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-8),
                    endDate = DateTime.Now.AddDays(12),
                    id = 104,
                    customerName = "Emily Davis"
                }
            },
            new Vehicles
            {
                ID = 5,
                licensePlate = "JKL012",
                brand = "Chevrolet",
                model = "Malibu",
                rentalContract = null
            },
            new Vehicles
            {
                ID = 6,
                licensePlate = "MNO345",
                brand = "Hyundai",
                model = "Elantra",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-20),
                    endDate = DateTime.Now.AddDays(1),
                    id = 105,
                    customerName = "Michael Wilson"
                }
            },
            new Vehicles
            {
                ID = 7,
                licensePlate = "PQR678",
                brand = "Kia",
                model = "Optima",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-3),
                    endDate = DateTime.Now.AddDays(18),
                    id = 106,
                    customerName = "Sarah Brown"
                }
            },
            new Vehicles
            {
                ID = 8,
                licensePlate = "STU901",
                brand = "Mazda",
                model = "3",
                rentalContract = null
            },
            new Vehicles
            {
                ID = 9,
                licensePlate = "VWX234",
                brand = "Subaru",
                model = "Impreza",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-12),
                    endDate = DateTime.Now.AddDays(8),
                    id = 107,
                    customerName = "David Miller"
                }
            },
            new Vehicles
            {
                ID = 10,
                licensePlate = "YZA567",
                brand = "Volkswagen",
                model = "Jetta",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-7),
                    endDate = DateTime.Now.AddDays(14),
                    id = 108,
                    customerName = "Jessica Taylor"
                }
            },
            new Vehicles
            {
                ID = 11,
                licensePlate = "BCD890",
                brand = "Toyota",
                model = "Camry",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-25),
                    endDate = DateTime.Now.AddDays(-5),
                    id = 109,
                    customerName = "Thomas Anderson"
                }
            },
            new Vehicles
            {
                ID = 12,
                licensePlate = "EFG123",
                brand = "Honda",
                model = "Accord",
                rentalContract = null
            },
            new Vehicles
            {
                ID = 13,
                licensePlate = "HIJ456",
                brand = "Ford",
                model = "Fusion",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-18),
                    endDate = DateTime.Now.AddDays(2),
                    id = 110,
                    customerName = "Jennifer Martinez"
                }
            },
            new Vehicles
            {
                ID = 14,
                licensePlate = "KLM789",
                brand = "Nissan",
                model = "Sentra",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-1),
                    endDate = DateTime.Now.AddDays(20),
                    id = 111,
                    customerName = "Christopher Lee"
                }
            },
            new Vehicles
            {
                ID = 15,
                licensePlate = "NOP012",
                brand = "Chevrolet",
                model = "Cruze",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-9),
                    endDate = DateTime.Now.AddDays(11),
                    id = 112,
                    customerName = "Amanda White"
                }
            },
            new Vehicles
            {
                ID = 16,
                licensePlate = "QRS345",
                brand = "Hyundai",
                model = "Sonata",
                rentalContract = null
            },
            new Vehicles
            {
                ID = 17,
                licensePlate = "TUV678",
                brand = "Kia",
                model = "Forte",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-14),
                    endDate = DateTime.Now.AddDays(6),
                    id = 113,
                    customerName = "Daniel Harris"
                }
            },
            new Vehicles
            {
                ID = 18,
                licensePlate = "WXY901",
                brand = "Mazda",
                model = "6",
                rentalContract = new rentalContract
                {
                    startDate = DateTime.Now.AddDays(-6),
                    endDate = DateTime.Now.AddDays(16),
                    id = 114,
                    customerName = "Olivia Clark"
                }
            },
        };
    }
}