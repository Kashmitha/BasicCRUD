namespace BasicCRUD.Models.DTO
{
    public class UpdateEmployeeDto
    {
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string Phone { get; set; }
        public required decimal Salary { get; set; }
    }
}
