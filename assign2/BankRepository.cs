//Kartik Gupta (Fareportal Tech Intern)
using System;
using System.Runtime.CompilerServices;

namespace bank{
    class BankRepository: IBankRepository{
        List<SBAccount> sbaccL = new List<SBAccount>();
        List<SBTransaction> sbtrcL = new List<SBTransaction>();

        public void NewAccount(SBAccount acc){
            sbaccL.Add(new SBAccount(acc.AccountNumber, acc.CustomerName, acc.CustomerAddress, acc.CurrentBalance));
            acc.TransactionCount = 0;
        }

        public List<SBAccount> GetAllAccounts(){
            return sbaccL;
        }

        public SBAccount GetAccountDetails(int accNo){
            SBAccount Record = null;
            foreach(var index in sbaccL){
                if(index.AccountNumber == accNo){
                    Record = index;
                    break;
                }
            }
            return Record;
        }
        public void DepositAmount(int accNo, float amt){
            SBAccount editRecord = null;
            foreach(var indexRecord in sbaccL){
                if(indexRecord.AccountNumber == accNo){
                    editRecord = indexRecord;
                    break; //exit out of the loop
                }
            }
            editRecord.CurrentBalance += amt;
            Console.WriteLine($"{amt} deposited in {editRecord.CustomerName} 's SB Account");
            // Console.WriteLine($"TransactionCount is {editRecord.TransactionCount}");
            sbtrcL.Add(new SBTransaction(editRecord.TransactionCount, DateTime.Now, accNo, amt, "Deposit"));
            editRecord.TransactionCount++;
            // Console.WriteLine($"TransactionCount is {editRecord.TransactionCount}");
        }

        public void WithdrawAmount(int accNo, float amt){
            SBAccount editRecord = null;
            foreach(var indexRecord in sbaccL){
                if(indexRecord.AccountNumber == accNo){
                    editRecord = indexRecord;
                    break;
                }
            }
            if(editRecord.CurrentBalance>amt){
                editRecord.CurrentBalance -= amt;
                Console.WriteLine($"{amt} withdrawed from {editRecord.CustomerName} 's SB Account");
                sbtrcL.Add(new SBTransaction(editRecord.TransactionCount, DateTime.Now, accNo, amt, "Withdraw"));
                editRecord.TransactionCount += 1;
            }
            else{
                Console.WriteLine("Not enough balance");
            }
        }

        public List<SBTransaction> GetTransactions(int accno){
            SBTransaction record = null;
            List<SBTransaction> specificAcc = new List<SBTransaction>();
            foreach(var item in sbtrcL){
                if(item.AccountNumber==accno){
                    specificAcc.Add(new SBTransaction(item.TransactionId, item.TransactionDate, item.AccountNumber, item.Amount, item.TransactionType));
                }
            }
            return specificAcc;
        }

    }
}