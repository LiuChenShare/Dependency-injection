using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    /// <summary>
    /// 武器
    /// </summary>
    public interface IAttackStrategy
    {
        void AttackTarget(Monster monster);
    }
}
