using Dimpeny.CharacterManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimpeny.CharacterManager.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string Bio { get; set; }
        public ClearenceLevel ClearenceLevel { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}
