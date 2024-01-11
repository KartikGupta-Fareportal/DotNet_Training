//Kartik Gupta (Fareportal Tech Intern)
using System;
using System.Data;
using System.Security.AccessControl;

namespace bank{
    class BankClient{
        public static void Main(){
            BankRepository obj = new BankRepository();
            Console.WriteLine("----------Menu driven bank program -------");
            while(true){
                Console.WriteLine();
                Console.WriteLine("Enter 1 for adding new bank account");
                Console.WriteLine("Enter 2 for getting details of all accounts");
                Console.WriteLine("Enter 3 for getting account details of a specific account");
                Console.WriteLine("Enter 4 for depositing money");
                Console.WriteLine("Enter 5 for withdrawing money");
                Console.WriteLine("Enter 6 for listing all transactions on account");
                Console.WriteLine("Enter 0 to exit");
                string input = Console.ReadLine();
                if(input=="0"){
                    Console.WriteLine("Exiting Program");
                    break;
                }
                else if(input=="1"){
                    Console.WriteLine();
                    Console.WriteLine("--------Add New Account-------");
                    Console.WriteLine("Enter account number: ");
                    int acc = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter customer name: ");
                    string custName = Console.ReadLine();
                    Console.WriteLine("Enter customer address: ");
                    string custAddr = Console.ReadLine();
                    Console.WriteLine("Enter current balance: ");
                    float currBal = float.Parse(Console.ReadLine());
                    SBAccount accobj = new SBAccount(acc, custName, custAddr, currBal);
                    obj.NewAccount(accobj);
                }
                else if(input=="2"){
                    Console.WriteLine();
                    Console.WriteLine("--------Details Of All Accounts-------");
                    List<SBAccount> records = new List<SBAccount>();
                    records = obj.GetAllAccounts();
                    foreach(var item in records){
                        Console.WriteLine($"AccNo - {item.AccountNumber} | CustName - {item.CustomerName} | CustAddress - {item.CustomerAddress} | CurrBal - {item.CurrentBalance}");
                    }
                }
                else if(input=="3"){
                    Console.WriteLine();
                    Console.WriteLine("-------Get Account Details-----");
                    Console.WriteLine("Enter account number: ");
                    int acc = Convert.ToInt32(Console.ReadLine());
                    SBAccount item = obj.GetAccountDetails(acc);
                    Console.WriteLine("The account details are as follows: ");
                    Console.WriteLine($"AccNo - {item.AccountNumber} | CustName - {item.CustomerName} | CustAddress - {item.CustomerAddress} | CurrBal - {item.CurrentBalance}");
                }
                else if(input=="4"){
                    Console.WriteLine();
                    Console.WriteLine("--------Deposit Amount----------");
                    Console.WriteLine("Enter account number: ");
                    int acc = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter amount to deposit: ");
                    float amt = float.Parse(Console.ReadLine());
                    obj.DepositAmount(acc, amt);
                }
                else if(input=="5"){
                    Console.WriteLine();
                    Console.WriteLine("--------Withdraw Amount----------");
                    Console.WriteLine("Enter account number: ");
                    int acc = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter amount to withdraw: ");
                    float amt = float.Parse(Console.ReadLine());
                    obj.WithdrawAmount(acc, amt);
                }
                else if(input=="6"){
                    Console.WriteLine();
                    Console.WriteLine("--------Get Transactions----------");
                    Console.WriteLine("Enter account number: ");
                    int acc = Convert.ToInt32(Console.ReadLine());
                    List<SBTransaction> transactions = obj.GetTransactions(acc);
                    foreach(var item in transactions){
                        Console.WriteLine($"TransactionId - {item.TransactionId} | TransactionDate - {item.TransactionDate} | Account Number - {item.AccountNumber} | Amount - {item.Amount} | Transaction Type - {item.TransactionType}");
                    }
                }
                else{
                    Console.WriteLine("invalid Input, Pls enter valid value");
                }
            }
        }
    }
}