﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class User
    {
        public string name;
        public string password;
        public long balance;
        public string lastacc;
        public string DOB;
        public List<string> l1;
        public User()
        {
        }
        public User(string n, string p,string d, long b, string l)
        {
            name = n;
            password = p;
            DOB = d;
            balance = b;
            lastacc = l;
        }
        public void passc(string pass)
        {
            password = pass;
        }
    }
}