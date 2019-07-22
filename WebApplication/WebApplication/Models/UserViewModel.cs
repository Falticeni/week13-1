using System.ComponentModel;


namespace Students.Web.Models
{
    public class UserViewModel
    {
        [DisplayName("Nume Utilizator")]
        public int Id { get; set; }

        [DisplayName("Nume Utilizator")]

        public string UserName { get; set; }

        [DisplayName("Adresa Email")]
        public string Email { get; set; }

        [DisplayName("Address")]
        public Address Adresa { get; set; }
        [DisplayName("Sex")]
        public Gender Sex { get; set; }
    }

    public class Address
    {
        [DisplayName("Strada")]
        public string Street { get; set; }

        [DisplayName("Oras")]
        public string City { get; set; }
    }

    public enum Gender {Masculin, Feminin}
}