namespace eShop_ApplicationCore.Model.Abstract
{
    public abstract class Person : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public static string GenerateIdentification(Person person)
        {
            if (person.LastName.Length <= 2)
            {
                var lastCharacter = person.LastName.Substring(person.LastName.Length - 1);
                person.LastName += lastCharacter;
            }

            if (person.FirstName.Length <= 2)
            {
                var lastCharacter = person.FirstName.Substring(person.FirstName.Length - 1);
                person.FirstName += lastCharacter;

            }
            return (person.FirstName.Substring(0, 3) + "-" + person.LastName.Substring(0, 3) + "-" + person.Id).ToUpper();
        }
    }
}
