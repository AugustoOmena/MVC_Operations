using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MVC_Operations.Data;
using MVC_Operations.Models;

namespace MVC_Operations.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly MVC_Operations.Data.MVC_OperationsContext _context;

        public IndexModel(MVC_Operations.Data.MVC_OperationsContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
