using System;

namespace CSharpDemo
{
    class MainClass
    {

        static public void Main(string[] args)
        {
            double balance = 5200;
            Console.WriteLine("Welcome to the World of cash!");
            InputHandler(balance);
        }

        static public int CashApp()
        {
            try 
            {
                Console.WriteLine("Enter a number: ");
                Console.WriteLine("1. View your balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                int input = Convert.ToInt32(Console.ReadLine());
                // we have to wrap Console.ReadLine in Convert.ToInt32
                // because we are using int when declaring our variable
                return input;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Input must be a number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Yay Task Complete!");
            }
           
            return 0;
        }

        static public double ViewBalance(double balance)
        {
            Console.WriteLine("your balance is: " + balance);
            InputHandler(balance);
            return balance;
        }

        static public void InputHandler(double balance)
        {

            int selection = CashApp();

            switch (selection)
            {
                case 1:
                    ViewBalance(balance);
                    break;
                case 2:
                    Withdraw(balance);
                    break;
                case 3:
                    Deposit(balance);
                    break;
                default:
                    Console.WriteLine("please choose from available options");
                    InputHandler(balance);
                    break;
            }
        }

        static public void Withdraw(double balance)
        {
            Console.WriteLine("How much would you like to withdraw today?");
            Console.WriteLine("1. $20");
            Console.WriteLine("2. $40");
            Console.WriteLine("3. $60");
            Console.WriteLine("4. $100");
            //Console.WriteLine("5. Enter a custom amount: $");

            int withDrawAmt = Convert.ToInt32(Console.ReadLine());
            balance -= withDrawAmt;
            ViewBalance(balance);
            InputHandler(balance);

        }

        static public void Deposit(double balance)
        {
            Console.WriteLine("How much money would you like to deposit? ");
            int depositAmt = Convert.ToInt32(Console.ReadLine());
            balance += depositAmt;
            ViewBalance(balance);
            InputHandler(balance);

        }
    }
}
