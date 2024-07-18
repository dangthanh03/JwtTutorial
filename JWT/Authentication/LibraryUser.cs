using JWT.DataAccess.Entities;
using Microsoft.AspNetCore.Identity;

namespace JWT.Authentication
{
    public class LibraryUser:IdentityUser
    {
        public bool RatingAllowed {  get; set; }
        public required ICollection<BookReview> Reviews { get; set; }
        public string? RefreshToken {  get; set; }

        public DateTime RefreshTokenExpiry {  get; set; }
    }
}
