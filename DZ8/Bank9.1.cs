using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    internal class Bank//9.1
    {

        private int acc_num;
        private double balance;
        private string type;

        private Queue<BankTransaction> transactionHistory; //для 9.2

        


        public Bank()
        {
            Generate_acc_num();
        }

        public Bank(double Balance)
        {
            balance = Balance;
            Generate_acc_num();
        }

        public Bank(string Type)
        {
            type = Type;
            Generate_acc_num();
        }

        public Bank(double Balance, string Type)
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
            Console.WriteLine("Номер счета: " + acc_num +"\n");
        }
    }
}
