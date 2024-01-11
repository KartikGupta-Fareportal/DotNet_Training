//Kartik Gupta (Fareportal Tech Intern)
using System;

namespace bank{
    public interface IBankRepository{
        void NewAccount(SBAccount acc);
        List<SBAccount> GetAllAccounts();
        SBAccount GetAccountDetails(int accNo);
        void DepositAmount(int accNo, float amt);
        void WithdrawAmount(int accNo, float amt);
        List<SBTransaction> GetTransactions(int accno);
    }
}