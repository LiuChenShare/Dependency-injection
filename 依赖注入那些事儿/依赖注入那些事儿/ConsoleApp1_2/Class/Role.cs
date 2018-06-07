using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_2.Class
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role
    {
        private Random _random = new Random();

        /// <summary>
        /// 表示角色目前所持武器
        /// </summary>
        public IAttackStrategy Weapon { get; set; }

        /// <summary>
        /// 攻击怪物
        /// </summary>
        /// <param name="monster">被攻击的怪物</param>
        public void Attack(Monster monster)
        {
            this.Weapon.AttackTarget(monster);
        }
    }
}
