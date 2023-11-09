using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    internal class Bank9
    {

        private int acc_num;
        private decimal balance;
        private string type;

        public decimal Balance  { get { return balance; } set { balance = value; } }
        private Queue<BankTransaction> transactionHistory;


        //для 9.3
        private Queue<string> transactions; // Очередь проводок
        private string filePath; // Путь к файлу для записи данных


        public Bank9(string filePath)
        {
            transactions = new Queue<string>();
            this.filePath = filePath;
        }

        /// <summary>
        /// добавляем новые транзакции в очередь
        /// </summary>
        /// <param name="transaction"></param>
        public void AddTransaction(string transaction)
        {
            transactions.Enqueue(transaction);
        }
        public void Dispose()
        {
            // Записываем данные о проводках в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string transaction in transactions)
                {
                    writer.WriteLine(transaction);
                }
            }
            GC.SuppressFinalize(this); // Предотвращаем вызов метода завершения
        }

        //9.2
        public Bank9(decimal initialBalance)
        {
            balance = initialBalance;
            transactionHistory = new Queue<BankTransaction>();
        }

        public void Add(decimal money)
        {
            balance += money;
            transactionHistory.Enqueue(new BankTransaction(money));
        }

        public void Minus(decimal money)
        {
            if (money <= balance)
            {
                balance -= money;
                transactionHistory.Enqueue(new BankTransaction(-money));
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }


        public Bank9(decimal Balance, string Type)
        {
            balance = Balance;
            type = Type;
            Generate_acc_num();
        }

        /// <summary>
        /// метод, генерирующий номер счета
        /// </summary>
        private void Generate_acc_num()
        {
            Random random = new Random();
            acc_num = Convert.ToInt32(random.Next(100000, 999999).ToString());
        }

        /// <summary>
        /// метод для выода информации
        /// </summary>
        public void GiveInf()
        {
            Console.WriteLine("Баланс: " + balance);
            Console.WriteLine("Тип банковского счета: " + type);
            Console.WriteLine("Номер счета: " + acc_num);
        }
    }
}
