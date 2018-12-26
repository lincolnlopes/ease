using System;
namespace Ease.Domain.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
//        public DateTime? DateBirth { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Base64FormattingOptions? ProfilePicture { get; set; }
    }
}