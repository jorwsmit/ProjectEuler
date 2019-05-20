using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectEuler.Models
{
    public class CodeSolutions
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CodeSolution { get; set; }
        public string Problem { get; set; }
        public string ProjectEulerLink { get; set; }
    }
}