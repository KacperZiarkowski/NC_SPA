namespace eShop_ApplicationCore.Model.Abstract
{
    interface IPerson : IEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
    }
}
