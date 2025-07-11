﻿namespace BasicCRUD.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string Phone { get; set; }
        public required decimal Salary { get; set; }
    }
}
