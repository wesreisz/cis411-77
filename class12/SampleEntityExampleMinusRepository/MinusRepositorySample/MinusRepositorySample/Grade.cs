using System.Collections.Generic;

namespace MinusRepositorySample
{
    public class Grade
    {
        public Grade() { }
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}