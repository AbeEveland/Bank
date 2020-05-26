
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

using CsvHelper;

namespace Bank
{
    class Program
    {

        class checkingaccount
        {
            public int checking { get; set; }
        }
        class savingsaccount
        {
            public int savings { get; set; }
        }

        static void Main(string[] args)

        {
            var savingstransactions = new List<savingsaccount>();
            var checkingtransactions = new List<checkingaccount>();





            // checking.Add(firstdeposit);

            //for (int i = 0; i < checking.Count; i++)
            //{
            //v
            // Console.WriteLine($"Your checking account has {checking[i].checkingaccount} dollars in it");

            //}





            //var fileWriter = new StreamWriter("numbers.csv");
            // ar csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture)
            // csvWriter.WriteRecords(numbers);
            //  fileWriter.Close();
            // 

            //Identify expected input and output
            //Make the requirements explicit
            //Identify rules
            //Mental model of the problem (optional)



            //Problem: create a bank account that you can manage,
            // load transactions from file on stgarup
            // be able to see transactions on startup
            // dont allow over drawing
            //deposit to a checks and savings account. withdrawl
            // from a checkings and savings account. be able
            // to view account summary.
            // prompt for amount to deposit or withdraw and make 
            // sure it is a positive nuimber.
            // write all transactions to a file. 

            // 1. app should load past transactions on startup. 

            // 2. view balances of savings and checking on startup.

            // 3. do not allow over drawing. 

            // 4. always ensure positive amount 

            // 5. deposit into savings
            //a. create a list (savings)

            while (1 == 1)
            {

                Console.Write("(v)iew accounts, (d)eposit, (w)ithdraw,");
                string choice = Console.ReadLine();
                if (choice == "v" || choice == "V")
                {
                    Console.Write($"would you like to see your (c)hecking, or (s)avings?,");
                    string choices2 = Console.ReadLine();
                    if (choices2 == "c" || choices2 == "C")
                    {



                        //checking.Add(firstdeposit);

                        //foreach (var checkingDeposit in checking) Console.WriteLine(checkingDeposit);

                        //var sum = checkingtransactions.Sum(checkingtransactions => checkingtransactions);
                        var sum = checkingtransactions.Sum(checkingaccount => checkingaccount.checking);
                        Console.WriteLine(sum);

                        //var totalchecking = checking.Aggregate(0, (currentTotal, Accounts) => currentTotal + Accounts.totalchecking);
                        //Console.WriteLine(totalchecking);
                        //static int sum (this System.Collections.Generic.IEnumerable<Nullable<int>> source);

                        //  float Sums = Accounts.Sum();

                        // Console.WriteLine("Your checking account has  {0}", Sums);




                    }

                    if (choices2 == "s" || choices2 == "S")
                    {
                        //foreach (var savingsDeposit in checking) Console.WriteLine(savingsDeposit);
                        // for (int i = 0; i < savings.Count; i++)
                        //{
                        //   Console.WriteLine(savings[i].savingsaccount);

                        //}


                        var sum = savingstransactions.Sum(savingsaccount => savingsaccount.savings);
                        Console.WriteLine(sum);


                    }



                }
                if (choice == "D" || choice == "d")
                {
                    Console.Write($"would you like to deposit into (c)hecking, or (s)avings?,");
                    string choices = Console.ReadLine();
                    if (choices == "c" || choices == "C")
                    {
                        Console.WriteLine($"How much would you like to deposit?");
                        int newDepositchecking = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Thank you!");
                        Console.WriteLine($"{newDepositchecking} Has been added to your checking account");
                        checkingaccount checkingDeposit = new checkingaccount
                        {
                            checking = newDepositchecking,
                        };
                        checkingtransactions.Add(checkingDeposit);
                    }
                    if (choices == "s" || choices == "S")
                    {
                        Console.WriteLine($"How much would you like to deposit?");
                        int newDepositsavings = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Thank you!");
                        Console.WriteLine($"{newDepositsavings} Has been added to your savings account");
                        savingsaccount savingsDeposit = new savingsaccount
                        {
                            savings = newDepositsavings,
                        };
                        savingstransactions.Add(savingsDeposit);

                    }

                }

                if (choice == "W" || choice == "w")
                {



                    Console.Write("Would you like to withdraw from (c)hecking, or (s)avings?");
                    string withdrawchoices = Console.ReadLine();

                    if (withdrawchoices == "c" || withdrawchoices == "C")
                    {
                        Console.WriteLine($"How much would you like to withdraw?");
                        int newWithdrawchecking = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Thank you!");
                        Console.WriteLine($"{newWithdrawchecking} Has been removed from your checking account");
                        checkingaccount checkingWithdraw = new checkingaccount
                        {
                            checking = newWithdrawchecking,
                        };
                        checkingtransactions.Re
                        move(checkingWithdraw);
                    }
                    if (withdrawchoices == "s" || withdrawchoices == "S")
                    {
                        Console.WriteLine($"How much would you like to withdraw?");
                        int newWithdrawsavings = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Thank you!");
                        Console.WriteLine($"{newWithdrawsavings} Has been removed from your savings account");
                        savingsaccount checkingWithdraw = new savingsaccount
                        {
                            savings = newWithdrawsavings,
                        };
                        savingstransactions.Remove(checkingWithdraw);
                    }


                }
            }
            //if (choice == "v" || choice == "V")
            //{
            //  Console.Write($"would you like to see your (c)hecking, or (s)avings?,");
            //string viewchoices = Console.ReadLine();
            //if (viewchoices == "c" || viewchoices == "C")
            //{
            // Console.WriteLine(checking);

            // (int i = 0; i < savings.Count; i++)
            // {
            //  Console.WriteLine($"{savings[i].savingsaccount}");

            //}
            //}
            //}





            //if (choice == "V" || choice == "v")
            //{

            // Summary();

            //}






            //b. add int one at a time to list(savings)




            // 6. deposit into checking
            // a. create a list (checking)


            // b. add int one at a time to list (checking)

            // 7. withdraw from savings 
            // a. remove a specific element from list (savings)


            // 8. withdraw from checkings. 
            // a. remove a specific element from list (checking)


            // 9. view account balances. 

            // 10. after each transaction, write to a file using standard format.   


            //break;

        }
    }
}



