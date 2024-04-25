namespace ShoppingCart.Models
{
    public record User(int Id, string FirstName, string MiddleName, string LastName, DateTime DateOfBirth, Gender Gender, PhoneNumber PhoneNumber, Address Address);
}
