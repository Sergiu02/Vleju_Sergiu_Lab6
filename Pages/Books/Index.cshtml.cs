using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vleju_Sergiu_Lab6.Data;
using Vleju_Sergiu_Lab6.Models;

namespace Vleju_Sergiu_Lab6.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Vleju_Sergiu_Lab6.Data.Vleju_Sergiu_Lab6Context _context;

        public IndexModel(Vleju_Sergiu_Lab6.Data.Vleju_Sergiu_Lab6Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
