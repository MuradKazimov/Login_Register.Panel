using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage
{
    internal class Account
    {
        public string login;
        public string password;

        public Account(string _login, string _password)
        {
            login = _login;
            password = _password;
        }
    }
    internal class AccountClass
    {
        private static Account[] registeredAccounts = { new Account("Admin", "admin123") };


        private static Account FindAccountByLogin(string login)
        {
            foreach (Account account in registeredAccounts)
            {
                if (account.login == login)
                {
                    return account;
                }
            }

            return null;
        }

        public static bool DoesAccountExist(string login)
        {
            foreach (Account account in registeredAccounts)
            {
                if (account.login == login)
                {
                    return true;
                }
            }

            return false;
        }
        public static Account Login(string login, string password)
        {
            Account account = FindAccountByLogin(login);
            if (!(account == null) && account.password == password)
            {
                return account;
            }
            return null;
        }

        public static Account Register(string login, string password)
        {
            if (DoesAccountExist(login))
            {
                return null;
            }

            Account newAcc = new Account(login, password);
            registeredAccounts = registeredAccounts.Append(newAcc).ToArray();
            return newAcc;
        }
    }
}
