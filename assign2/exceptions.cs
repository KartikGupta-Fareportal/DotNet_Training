using System;

namespace bank{
    class AccountNotValidException:ApplicationException{
        public AccountNotValidException(string message) : base (message) {}
    }
    class InsufficientBalanceException:ApplicationException{
        public InsufficientBalanceException(string message) : base(message){}
    }
    class AmountNotValidException:ApplicationException{
        public AmountNotValidException(string message) : base (message){}
    }
}