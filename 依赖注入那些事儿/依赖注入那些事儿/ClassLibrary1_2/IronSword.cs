using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    /// <summary>
    /// 铁剑类
    /// </summary>
    public class IronSword: IAttackStrategy
    {
        public void AttackTarget(Monster monster)
        {
            monster.Notify(50);
        }
    }
}
