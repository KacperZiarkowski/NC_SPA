namespace eShop_ApplicationCore.Model.Abstract
{
    public interface IPerson
    {
        string FirstName { get; }
        string LastName { get; }
        string Email { get; }
        string PhoneNumber { get; }
    }
}
