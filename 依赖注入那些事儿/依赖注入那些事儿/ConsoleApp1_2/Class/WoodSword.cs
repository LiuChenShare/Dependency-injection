using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_2.Class
{
    /// <summary>
    /// 木剑类
    /// </summary>
    public class WoodSword : IAttackStrategy
    {
        public void AttackTarget(Monster monster)
        {
            monster.Notify(20);
        }
    }
}
