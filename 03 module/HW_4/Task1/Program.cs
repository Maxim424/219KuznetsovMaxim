using System;

namespace Task1
{
    public class RingIsFoundEventArgs : EventArgs
    {
        public RingIsFoundEventArgs(string s) { Message = s; }
        public String Message { get; set; }
    }

    public abstract class Creature
    {
        public string Name { get; private set; }
        public Creature(string s) { Name = s; }
        protected string location;
    }

    public class Wizard : Creature
    {
        //2) событийный делегат
        public delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);
        //3) событие "Кольцо найдено"
        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;
        public Wizard(string s) : base(s) {
            location = "Ривендейл";
        }
        // Когда волшебнику кажется, что кольцо найдено, он вызывает этот метод
        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо! Призываю вас в Ривендейл! ");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
        }
    }

    public class Hobbit : Creature
    {
        public Hobbit(string s) : base(s) {
            location = "Шир";
        }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Покидаю {location}! Иду в {e.Message}");
            location = e.Message;
        }
    }

    public class Human : Creature
    {
        public Human(string s) : base(s) {
            location = "Изенгард";
        }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Волшебник {((Wizard)sender).Name} позвал. Моя цель {e.Message}. Сейчас я в {location}");
            location = e.Message;
        }
    }

    public class Elf : Creature
    {
        public Elf(string s) : base(s) {
            location = "Лихолесье";
        }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают идти в {e.Message}. Сейчас я в {location}");
            location = e.Message;
        }
    }

    public class Dwarf : Creature
    {
        public Dwarf(string s) : base(s) {
            location = "Одинокая гора";
        }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Выдвигаемся в {e.Message}. Сейчас я в {location}");
            location = e.Message;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Гендальф");
            Hobbit[] hobbits = new Hobbit[4];
            hobbits[0] = new Hobbit("Фродо");
            hobbits[1] = new Hobbit("Сэм");
            hobbits[2] = new Hobbit("Пипин");
            hobbits[3] = new Hobbit("Мэрри");
            for (int i = 0; i < hobbits.Length; i++)
            {
                wizard.RaiseRingIsFoundEvent += hobbits[i].RingIsFoundEventHandler;
            }
            Human[] humans = { new Human("Боромир"), new Human("Арагорн") };
            Dwarf dwarf = new Dwarf("Гимли");
            Elf elf = new Elf("Леголас");
            // подписывает гномов, людей и эльфов на событие
            wizard.RaiseRingIsFoundEvent += dwarf.RingIsFoundEventHandler;
            wizard.RaiseRingIsFoundEvent += elf.RingIsFoundEventHandler;
            foreach (Human h in humans)
                wizard.RaiseRingIsFoundEvent += h.RingIsFoundEventHandler;
            // волшебник оповещает всех 
            wizard.SomeThisIsChangedInTheAir();

            Creature[] array = new Creature[9];
            array[0] = wizard;
            for (int i = 0; i < hobbits.Length; i++)
            {
                array[i + 1] = hobbits[i];
            }
            for (int i = 0; i < humans.Length; i++)
            {
                array[i + 5] = humans[i];
            }
            array[7] = dwarf;
            array[8] = elf;

            Console.WriteLine();
            ((Wizard)array[0]).SomeThisIsChangedInTheAir();
        }
    }
}
