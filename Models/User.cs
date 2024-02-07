using System.ComponentModel.DataAnnotations;

namespace WebApp_Test_CRUD.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //public User(int id, string firstName, string lastName, string email)
        //{
        //    Id = id;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Email = email;

        //}
    }
}
