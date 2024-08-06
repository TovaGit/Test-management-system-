using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    public class Question
    {
        public string? question { get; set; }
        public List<string>? questionOption { get; set; }
        public int? answer { get; set; }
        public string? id { get; set; }
        public string? type { get; set; }
        public int score { get; set; }
        public int? secondAnswer { get; set; }

    }
}
