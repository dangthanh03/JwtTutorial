using JWT.DataAccess.Entities;

namespace JWT.DataAccess.Repository
{
    public interface IReviewRepository
    {
        public IQueryable<BookReview> AllReviews { get; }

        void Create(BookReview review);
        void Remove(BookReview result);
        void SaveChanges();
    }
}
