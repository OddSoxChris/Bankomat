using System;

namespace Testing
{
    public class Account
    {
        private int CardNumber;
        private int Pin;
        private int Balance;
        public Account(int UserCardNumber, int UserPin, int UserBalance)
        {
            CardNumber = UserCardNumber;
            Pin = UserPin;
            Balance = UserBalance;
        }
        private bool CheckPin(int UserPin, int UserCardNumber)
        {
            if (Pin == UserPin && CardNumber == UserCardNumber)
            {
                return true;
            }
            return false;
        }
        public bool Withdraw(int UserPin, int UserCardNumber, int Cash, int AtmCash)
        {
            if (CheckPin(UserPin, UserCardNumber) == false)
            {
                return false;
            }
            if (Balance >= Cash && AtmCash >= Cash)
            {
                Balance -= Cash;
                return true;
            }
            return false;
        }
        public bool Deposit(int UserPin, int UserCardNumber, int Cash)
        {
            if (CheckPin(UserPin, UserCardNumber) == false)
            {
                return false;
            }
            Balance += Cash;
            return true;
        }
        public int GetUserCardNumber()
        {
            return CardNumber;
        }
        public int GetUserPin()
        {
            return Pin;
        }
        public int CheckBalance(int UserPin, int UserCardNumber)
        {
            if (CheckPin(UserPin, UserCardNumber))
            {
                return Balance;
            }
            return -1;
        }
    }
    }
