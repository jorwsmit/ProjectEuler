using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectEuler.Models
{
    public class CodeSolutionsContext : DbContext
    {
        public CodeSolutionsContext (DbContextOptions<CodeSolutionsContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectEuler.Models.CodeSolutions> CodeSolutions { get; set; }
    }
}