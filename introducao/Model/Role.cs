using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introducao.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
    }
}