using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class EFBookRepository : IBookRepository
    {
        private readonly BookDbContext _context;

        //constructor
        public EFBookRepository(BookDbContext context)
        {
            _context = context;
        }

        //when 
        public IQueryable<Book> Books => _context.Books;
    }
}
