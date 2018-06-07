using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role
    {
        private Random _random = new Random();

        /// <summary>
        /// 表示角色目前所持武器的字符串
        /// </summary>
        public string WeaponTag { get; set; }

        /// <summary>
        /// 攻击怪物
        /// </summary>
        /// <param name="monster">被攻击的怪物</param>
        public void Attack(Monster monster)
        {
            if(monster.HP <= 0)
            {
                Console.WriteLine("此怪物已死");
                return;
            }

            if ("木剑" == this.WeaponTag)
            {
                monster.HP -= 20;
                if (monster.HP <= 0)
                {
                    Console.WriteLine("攻击成功！怪物" +monster.Name+ "已死亡");
                }
                else
                {
                    Console.WriteLine("攻击成功！怪物" + monster.Name + "损失20HP");
                }
            }
            else if ("铁剑" == this.WeaponTag)
            {
                monster.HP -= 50;
                if (monster.HP <= 0)
                {
                    Console.WriteLine("攻击成功！怪物" + monster.Name + "已死亡");
                }
                else
                {
                    Console.WriteLine("攻击成功！怪物" + monster.Name + "损失50HP");
                }
            }
            else if ("魔剑" == this.WeaponTag)
            {
                int loss = (_random.NextDouble() < 0.5) ? 100 : 200;
                monster.HP -= 20;
                if (loss == 200)
                {
                    Console.WriteLine("出现暴击！！！");
                }

                if (monster.HP <= 0)
                {
                    Console.WriteLine("攻击成功！怪物" + monster.Name + "已死亡");
                }
                else
                {
                    Console.WriteLine("攻击成功！怪物" + monster.Name + "损失" + loss + "HP");
                }
            }
            else
            {
                Console.WriteLine("角色手里没有武器，无法攻击！");
            }
        }
    }
}
