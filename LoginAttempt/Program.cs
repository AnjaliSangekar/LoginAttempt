using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAttempt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //login();

            Console.WriteLine();

            pattern();
            Console.WriteLine();

            numpattern();
        }

        public static void login()
        {
            string username;
            string password;
            int temp =0, c=0;

            do
            {
                Console.WriteLine("Enter username");
                username = Console.ReadLine();

                Console.WriteLine("Enter password");
                password = Console.ReadLine();


                if (username == "username" && password == "password")
                {
                    temp = 1;
                    c = 3;
                }
                else
                {
                    temp = 0;
                    c++;
                }
            }
            while ((username != "username" || password != "password") && (c != 3));


            if(temp == 0)
            {
                Console.WriteLine("Login attempt more than 3 time..Try later");
            }
            else
            {
                Console.WriteLine("Password enter successfully");
            }

        }


        public static void pattern()
        {
            int i, j, n = 5;

            for(i = 1; i <= n; i++)
            {
                for(j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        public static void numpattern()
        {
            int i, j, n = 5, k = 1;

            for( i = 1; i <= n;i++)
            {
                for(j = 1; j <= i;j++)
                {
                    Console.Write("{0} ", k);
                    k++;
                }

                Console.WriteLine();
            }
        }
    }
}
