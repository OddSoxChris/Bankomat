using System;
using System.Reflection.Metadata.Ecma335;

namespace Testing
{
    public class Atm
    {
        private int AtmCash;
        private Account[] Accounts;
        public Atm(int CashIn, Account[] UserAccounts)
        {
            AtmCash = CashIn;
            Accounts = UserAccounts;
        }
        public int Withdraw(int UserPin, int UserCardNumber, int UserCash)
        {
            if (AtmCash > 0 && UserCash <= AtmCash)
            {
                for (int i = 0; i < Accounts.Length; i++)
                {
                    if (Accounts[i].GetUserCardNumber() == UserCardNumber)
                    {
                        if (Accounts[i].Withdraw(UserPin, UserCardNumber, UserCash, AtmCash))
                        {
                            AtmCash -= UserCash;
                            return Accounts[i].CheckBalance(UserPin, UserCardNumber);
                        }
                    }
                }
            }
            return -1;
        }
        public int Deposit(int UserPin, int UserCardNumber, int UserCash)
        {
            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i].GetUserCardNumber() == UserCardNumber)
                {
                    if (Accounts[i].Deposit(UserPin, UserCardNumber, UserCash))
                    {
                        AtmCash += UserCash;
                        return Accounts[i].CheckBalance(UserPin, UserCardNumber);
                    }
                }
            }
            return -1;
        }
        public bool IsEmpty()
        {
           // if (AtmCash > 0)
                return true;
        }
        public int CheckAccountBalance(int UserPin, int UserCardNumber)
        {
            //for (int i = 0; i < Accounts.Length; i++)
            {
                //if (Accounts[i].GetUserCardNumber() == UserCardNumber)
                {
                    //return CheckAccountBalance(UserPin, UserCardNumber);
                }
                return -1;
            }
            // return CheckAccountBalance(UserPin, UserCardNumber);
        } 
    }
}
