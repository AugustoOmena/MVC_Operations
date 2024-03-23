using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Operations.Models;

namespace MVC_Operations.Data
{
    public class MVC_OperationsContext : DbContext
    {
        public MVC_OperationsContext (DbContextOptions<MVC_OperationsContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Operations.Models.User> User { get; set; } = default!;
    }
}
