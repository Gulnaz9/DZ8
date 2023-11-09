using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для упр 9.1; в классе банковского счета создать различные конструкторы");
            //объект с конструктором по умолчанию
            Bank acc1 = new Bank();
            acc1.GiveInf();

            //объект для заполнения баланса
            Bank acc2 = new Bank(2430);
            acc2.GiveInf();

            // объект для заполнения типа банк. счёта"
            Bank acc3 = new Bank("Текущий");
            acc3.GiveInf();

            // объект заполнения баланса и типа"
            Bank acc4 = new Bank(500000, "Сберегательный");
            acc4.GiveInf();


            Console.WriteLine("Для упр 9.2; создать новый класс BankTransaction, который будет хранить информацию о всех банковских операциях.");

            Bank9 acc = new Bank9(300);
            acc.Add(2430);
            acc.Minus(220);
            Console.WriteLine($"Текущий счёт: {acc.Balance}");



            Console.WriteLine("\nДля упр 9.3; создать метод Dispose, который данные о проводках из очереди запишет в файл");

            // Создаем объект BankAccount и добавляем проводки
            Bank9 bankAcc = new Bank9("transactions.txt");//не разобралась как связать всё с этим файлом
            bankAcc.AddTransaction("Transaction 1");
            bankAcc.AddTransaction("Transaction 2");
            bankAcc.AddTransaction("Transaction 3");

            bankAcc.Dispose();
            Console.WriteLine("Данные о проводках сохранены в файл");

            Song mySong = new Song();
        }
    }
}
