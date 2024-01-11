//Kartik Gupta (Fareportal Tech Intern)
using System;

namespace bank{
    public class SBAccount{
        public int AccountNumber{get;set;}
        public string CustomerName{get;set;}
        public string CustomerAddress{get;set;}
        public float CurrentBalance{get;set;}

        public int TransactionCount{get;set;}

        public SBAccount(int acnum, string custName, string custAddr, float currBal){
            AccountNumber = acnum;
            CustomerName = custName;
            CustomerAddress = custAddr;
            CurrentBalance = currBal;
        }
    }

    public class SBTransaction{
        public int TransactionId{get; set;}
        public DateTime TransactionDate{get; set;}
        public int AccountNumber{get; set;} 
        public float Amount{get; set;}
        public string TransactionType{get; set;}

        public SBTransaction(int tid, DateTime tdate, int accNo, float amt, string tt){
            TransactionId = tid;
            TransactionDate = tdate;
            AccountNumber = accNo;
            Amount = amt;
            TransactionType = tt;
        }
    }
}