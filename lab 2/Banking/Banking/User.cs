using System;

namespace banking
{
    public class User
    {
        public string name;
        public string password;
        public long balance;


        public User(string n,string p,long b)
        {
            name = n;
            password = p;
            balance = b;
        }
    }
}