using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterRecords
{
    class Character
    {
        public string name, characterClass, level, health;

        public Character(string _name, string _characterClass, string _level, string _health)
        {
            name = _name;
            characterClass = _characterClass;
            level = _level;
            health = _health;
        }
    }
}
