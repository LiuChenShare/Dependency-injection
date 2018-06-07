using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_1.Class
{
    /// <summary>
    /// 怪物
    /// </summary>
    public class Monster
    {
        /// <summary>
        /// 怪物的名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 怪物的生命值
        /// </summary>
        public int HP { get; set; }

        public Monster(string name, int hp)
        {
            this.Name = name;
            this.HP = hp;
        }
    }
}
