using System.Collections.Generic;

namespace Domain.Interviews
{
    public class DataItem
    {
        public string Ident { get; set; }
        public string Lang { get; set; }
        public List<string> Values { get; set; } = new List<string>();
    }
}
