namespace EtaxService.DTOs.Request
{   
    public class RoleUpdateRequest{
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class RoleDeleteRequest{
        public int ID { get; set; }
    }
    public class RoleCreateRequest{
        public string Name { get; set; }
        public string Description { get; set; }
    }
    
}
