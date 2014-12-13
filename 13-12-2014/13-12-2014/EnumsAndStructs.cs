using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_12_2014
{
    public class Test
    {
        public static T ParseEnum<T>(string name)
        {
            return (T)Enum.Parse(typeof(T), name);
        }
    }

    class EnumsAndStructs
    {
        static void Main(string[] args)
        {
            AccountType t = AccountType.Cheking;
            int int_t = (int)t;

            

            FileAttribute type1 = Test.ParseEnum<FileAttribute>("Hidden");


            FileAttribute type = FileAttribute.Archive | FileAttribute.System;
            bool isSystem = (type & FileAttribute.System) == FileAttribute.System;
            bool isArchive = (type & FileAttribute.Archive) == FileAttribute.Archive;
            bool isHidden = (type & FileAttribute.Hidden) == FileAttribute.Hidden;

            }
    }

    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;

        //public BankAccaunt()
        //{
        //    accNo = 123;
        //    accBal = 12;
        //    accType = AccountType.Cheking;
        //}

        public BankAccount(long no, decimal bal) : this()
        {
            accNo = no;
            accBal = bal;
            //accType = type;
        }
    }


    [Flags]
    public enum FileAttribute
    {
        Archive = 0,
        Hidden = 2,
        System = 4
    }

    public enum AccountType
    {
        Cheking = 10,
        Deposit
    }
}
