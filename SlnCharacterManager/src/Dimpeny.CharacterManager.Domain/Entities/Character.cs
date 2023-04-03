using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimpeny.CharacterManager.Domain.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int SettingId { get; set; }

        public virtual User? User { get; set; }
        //public virtual Setting? Setting { get; set; }
    }
}
