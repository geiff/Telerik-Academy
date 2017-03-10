namespace CommonTypeSystem.Contarcts
{
    using Enumerations;

    interface IStudent
    {
         string FirstName { get; set; }
         string MiddleName { get; set; }
         string LastName { get; set; }
         int Ssn { get; set; }
         string Address { get; set; }
         int MobilePhone { get; set; }
         string Email { get; set; }
         string Course { get; set; }
         Specialty Specialty { get; set; }
         University University { get; set; }
         Faculty Faculty { get; set; }
    }
}