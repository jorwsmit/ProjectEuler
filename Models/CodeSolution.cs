using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectEuler.Models
{
    public class CodeSolution
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Solution { get; set; }
        public string Problem { get; set; }
        public string Language { get; set; }
        public string ProjectEulerLink { get; set; }
    }
}