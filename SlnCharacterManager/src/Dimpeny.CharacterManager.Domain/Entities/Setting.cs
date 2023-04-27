using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimpeny.CharacterManager.Domain.Entities
{
    public class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
    }
}
