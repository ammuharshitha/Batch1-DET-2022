﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Batch1_DET_2022
{
    internal interface IEMail
    {
        string SendEMail();
    }

    public interface INotify
    {
        string SendSMS();
    }

    class Author : IEMail, INotify
    {
        public string Name { get; set; }
        public string EMail { get; set; }
        public char Gender { get; set; }

        public string SendEMail()
        {
            return $"Mail sent to {Name}, {EMail},{Gender}";
        }

        public string SendSMS()
        {
            return $"{Name} subscribed SMS notifications";
        }

        public static implicit operator Author(string v)
        {
            throw new NotImplementedException();
        }
    }

    class SITLAuthor : Author, IEMail
    {
        public string SendEMail()
        {
            return $"mail sent to Name={Name}, EMail={EMail},Gender={Gender}";
        }
    }

    class TestIAuthor
    {
        public static void Main()
        {
            Author a = new Author { Name = "ammu", EMail = "ammuharshitha", Gender = 'F' };
            SITLAuthor sa = new SITLAuthor { Name = "rashmi", EMail = "rashmi.123", Gender = 'F' };

            Console.WriteLine(a.SendEMail());
            Console.WriteLine(a.SendSMS());
            Console.WriteLine(sa.SendEMail());
        }
    }
}
