using MyGame.Characters;
using MyGame.Items;
using System;
using static System.Console;

// README.md를 읽고 아래에 코드를 작성하세요.
WriteLine("=== 캐릭터 시스템 ===");
Player pl = new Player();
Enemy en = new Enemy();
pl.Attack("용사");
en.TakeDamage("고블린");

Console.WriteLine("=== 아이템 시스템 ===");

Weapon wp = new Weapon();
Potion pt = new Potion();
wp.GetDamage("불꽃검");
pt.Use("체력 포션");




namespace MyGame.Characters
{
    public class Player
    {
        public string Name;
        public void Attack(string name)
        {
            Console.WriteLine($"플레이어 {name}(이)가 공격합니다!");

        }
    }
    public class Enemy
    {
        public string Type;

        public void TakeDamage(string type)
        {
            Console.WriteLine($"적 {type}(이)가 데미지를 받았습니다!");
        }
    }
}

namespace MyGame.Items
{
    public class Weapon
    {
        public string Name;

        public void GetDamage(string name)
        {
            Console.WriteLine($"무기 {name}의 공격력:50");
        }
    }
    public class Potion
    {
        public string Name;

        public void Use(string name)
        {
            Console.WriteLine($"포션 {name}을(를) 사용했습니다.");
        }
    }
}