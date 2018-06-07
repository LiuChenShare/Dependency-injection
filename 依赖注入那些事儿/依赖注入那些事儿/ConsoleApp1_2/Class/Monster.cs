using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_2.Class
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

        public void Notify(int loss)
        {
            if (this.HP <= 0)
            {
                Console.WriteLine("此怪物已死");
                return;
            }

            this.HP -= loss;
            if (this.HP <= 0)
            {
                Console.WriteLine("怪物" + this.Name + "被打死");
            }
            else
            {
                Console.WriteLine("怪物" + this.Name + "损失" + loss + "HP");
            }
        }
    }
}
