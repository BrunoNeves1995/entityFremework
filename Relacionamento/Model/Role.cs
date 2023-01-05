using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introducao.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Slug { get; set; }

        public IList<User>? Users { get; set; }
    }
}