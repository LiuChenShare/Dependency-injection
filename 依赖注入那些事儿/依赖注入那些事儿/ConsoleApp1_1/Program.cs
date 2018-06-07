using ConsoleApp1_1.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //生成怪物
            Monster monster1 = new Monster("小怪A", 50);
            Monster monster2 = new Monster("小怪B", 50);
            Monster monster3 = new Monster("关主", 200);
            Monster monster4 = new Monster("最终BOSS", 1000);

            //生成角色
            Role role = new Role();

            //木剑攻击
            role.WeaponTag = "木剑";
            while (monster1.HP > 0)
            {
                role.Attack(monster1);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("\n" + "获得铁剑，进入下一关..." + "\n\n");

            //铁剑攻击
            role.WeaponTag = "铁剑";
            while (monster2.HP > 0)
            {
                role.Attack(monster2);
                System.Threading.Thread.Sleep(1000);
            }
            while (monster3.HP > 0)
            {
                role.Attack(monster3);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("\n" + "获得魔剑，进入下一关..." + "\n\n");

            //魔剑攻击
            role.WeaponTag = "魔剑";
            while (monster4.HP > 0)
            {
                role.Attack(monster4);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("\n\n" + "通关");


            Console.ReadLine();
        }
    }
}
