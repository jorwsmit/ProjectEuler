using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectEuler.Models
{
    public class CodeSolutionContext : DbContext
    {
        public CodeSolutionContext (DbContextOptions<CodeSolutionContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectEuler.Models.CodeSolution> CodeSolution { get; set; }
    }
}