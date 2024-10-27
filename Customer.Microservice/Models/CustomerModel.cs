namespace Customer.Microservice.Models
{
    public class CustomerModel
    {
        // Essential attributes
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        // Optional attributes
        public bool IsActive { get; set; }
        public string Notes { get; set; }

        // Constructor
        public CustomerModel()
        {
            CreatedDate = DateTime.Now;
            IsActive = true;
        }

        // Methods
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void DeactivateCustomer()
        {
            IsActive = false;
            LastUpdatedDate = DateTime.Now;
        }
    }
}
