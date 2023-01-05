using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introducao.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
    }
}