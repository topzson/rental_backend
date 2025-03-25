using System.ComponentModel.DataAnnotations;
namespace rentalApi.Models
{
       public class Vehicles
    {
        [Key]
        public int ID { get; set; }
    
        public string? licensePlate { get; set; }

        public string? brand { get; set; }

        public string? model { get; set; }

        public rentalContract? rentalContract { get; set; }

    
    }

    public class rentalContract
    {
        [Key]
        public int? id { get; set; }
        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }


        public string? customerName { get; set; }
    }
}