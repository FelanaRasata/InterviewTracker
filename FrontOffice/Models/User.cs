namespace FrontOffice.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public UserRole Role { get; set; } = UserRole.USER;
    }

    public enum UserRole
    {
        ADMIN,
        USER
    }
}
