using System.Collections.Generic;
using System.Dynamic;

namespace RESXEdit.Models
{
    public class GridModel
    {
        public List<ExpandoObject> Items { get; set; }
        public List<string> Columns = new List<string>();
    }
}