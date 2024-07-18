using JWT.Authentication;
using JWT.DataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace JWT.DataAccess.Context
{
    public class ReviewContext: IdentityDbContext
    {


        public ReviewContext(DbContextOptions<ReviewContext> options)
        : base(options)
        {
        }

        public DbSet<BookReview> BookReviews { get; set; }
        public DbSet<LibraryUser> LibraryUsers { get; set; }
      
    }
}