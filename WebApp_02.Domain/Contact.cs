using WebApp_02.Domain.Common;

namespace WebApp_02.Domain
{
    public class Contact : Entity
    {
        public required string Email { get; set; }
        public string? Subject { get; set; }
        public required string Message { get; set; }
    }
}