
namespace BookStore.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}; {FirstName} {MiddleName} {LastName}";
        }
    }
}
