﻿using JWT.DataAccess.Context;
using JWT.DataAccess.Entities;

namespace JWT.DataAccess.Repository
{
    public class SqlServerRepository : IReviewRepository
    {
        private readonly ReviewContext _reviewContext;

        public SqlServerRepository(ReviewContext reviewContext)
        {
            _reviewContext = reviewContext;
        }

        public IQueryable<BookReview> AllReviews => _reviewContext.BookReviews;

        public void Create(BookReview review) => _reviewContext.BookReviews.Add(review);

        public void Remove(BookReview review) => _reviewContext.BookReviews.Remove(review);

        public void SaveChanges() => _reviewContext.SaveChanges();
    }
}
