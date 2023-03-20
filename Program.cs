using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{   //Класс со свойствами заклинания
    class Spell
    {
        //Инициализация свойств
        public int Mana { get; private set; }
        private string Effect { get; set; }
        public string Name { get; private set; }

        //Конструктор, принимающий значения заклинания
        public Spell(int mana, string effect, string name)
        {
            Mana = mana;
            Effect = effect;
            Name = name;
        }

        //Метод использования заклинания, вывод эффект от заклинания
        public string Use()
        {
            return Effect;
        }
    }

    //Класс со свойствами мага
    class Magician
    {
        //Свойства класса Маг
        public string Name { get; private set; }
        public int Mana { get; private set; }

        //Конструтор, принимающий значения мага
        public Magician(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }

        //Колдонуть с проверкой маны
        public void CastSpell(Spell spell)
        {
            if (Mana >= spell.Mana)
            {
                Console.WriteLine($"{Name} колдует! {spell.Use()}");
                Mana -= spell.Mana;
            }
            else
            {
                Console.WriteLine($"Для использования \"{spell.Name}\" не хватает {spell.Mana - Mana} единиц маны");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создание объектов заклинаний
            Spell rain = new Spell(60, "Идёт дождь!", "Дождь");
            Spell sun = new Spell(41, "Солнце светит!", "Свет солнца");

            //Создание объекта Маг
            Magician man = new Magician("Этот крутой мужчина", 100);

            //Использование заклинаний
            man.CastSpell(rain);
            man.CastSpell(sun);

            Console.ReadKey(true);
        }
    }
}