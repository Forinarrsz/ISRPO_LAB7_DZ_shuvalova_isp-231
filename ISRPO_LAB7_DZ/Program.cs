namespace ISRPO_LAB7_DZ
{
    internal class Program
    {
        static void Main(string[] args)
        { //1
            book defaultbook = new book();
            book kniga = new book("shine", "stephen king", 1977, true);
            defaultbook.Printinfo();
            kniga.Printinfo();
            //2
            BankAccount bank = new BankAccount();
            bank.Deposit(1000);
            bank.snatie(500);
            bank.printinfo();
            //3
            Car cr = new Car();
            cr.Accelerate(120);
            cr.Brake();
            Dice dice6 = new Dice();
            Dice dice12 = new Dice(12);
            //4
            Console.Write("6-гранный: ");
            for (int i = 0; i < 3; i++)
                Console.Write(dice6.Roll() + (i < 2 ? ", " : "\n"));

            Console.Write("12-гранный: ");
            for (int i = 0; i < 3; i++)
                Console.Write(dice12.Roll() + (i < 2 ? ", " : "\n"));
            //5
            Character warrior = new Character("Воин", 100, 50);
            Character mage = new Character("Маг", 80, 120);
            Character archer = new Character("Лучник", 90, 60);
            warrior.Attack();
            mage.Attack();
            archer.Attack();

        }
    }
}
