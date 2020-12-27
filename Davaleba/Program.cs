using System;
using System.Collections.Generic;

namespace Davaleba
{

    public class Davaleba
    {
        //1

       public static bool Ispalindrome (String text)
        {
            bool ispalindrome;
            char[] ch= new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                ch[i] =(text[text.Length-1 - i]);
            }
            string st = new string(ch);
            if (st == text)
            {
                ispalindrome= true;
            }
            else
            {
                ispalindrome= false;
            }
            Console.WriteLine(ispalindrome);
            return ispalindrome;

            
        }


        //2
        public static int MinSplit(int amount)

        {
            int raodenoba=0;
            int[] monetebi = { 1, 5, 10, 20, 50 };
            while (amount>0)
            {
                
                if (amount >= monetebi[4])
                {
                 amount =  amount - monetebi[4];
                    raodenoba++;
                }

                if (amount>=monetebi[3]&&amount< monetebi[4])
                {
                    amount -= monetebi[3];
                    raodenoba++;
                }

                if (amount >= monetebi[2] && amount < monetebi[3])
                {
                    amount -= monetebi[2];
                    raodenoba++;
                }

                if (amount >= monetebi[1] && amount < monetebi[2])
                {
                    amount -= monetebi[1];
                    raodenoba++;
                }

                if (amount >= monetebi[0] && amount < monetebi[1])
                {
                    amount -= monetebi[0];
                    raodenoba++;
                }



            }

            Console.WriteLine(raodenoba);
            return raodenoba;
        }

        //3

        public static int NotContains(int[] array)
        {
            int minnumber=0;
            int[] tempar;
            for (int i = 0; i < array.Length; i++)
                for (int k = 0; k < array.Length - 1; k++)
                    if (array[k] > array[k + 1])
                    {
                        int temp;
                        temp = array[k];
                        array[k] = array[k + 1];
                        array[k + 1] = temp;
                    }

            //uarkofiti ricxvebis gavutole nuls

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = 0;
                }
            }


            tempar = array;
           
            
            //aqamde davalaget array

            for (int i = 0; i < tempar.Length-1; i++)
            {
                if (tempar[i]-1>0)
                {
                   minnumber= tempar[i] - 1;
                    break;
                }

                if (tempar[i] != tempar[i + 1] - 1&& tempar[i + 1] - 1>0)
                {
                    minnumber = tempar[i + 1] - 1;
                    break;
                }

                if (tempar[i] - 1 <= 0)
                {

                    bool cond=false;

                        for (int j = 0; j < tempar.Length - 1; j++)
                        {
                            if (tempar[j + 1] - tempar[j] > 1)
                            {
                              minnumber = tempar[j + 1] - 1;
                              cond =true;
                              break;
                            }

                        }


                    if (cond == false) 
                    {
                        throw new Exception("piroba");
                    }

                    break;
                }
            }
            
            Console.WriteLine(minnumber);
            
            return minnumber;
        }

        //4
        public static bool IsProperly(String exp)
        {

             
            bool balanced = true;
            int count = 0;
            char[] ch = exp.ToCharArray();
            List<string> st = new List<string>();


            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '(' || ch[i] == ')')
                {
                    st.Add(ch[i].ToString());
                }
            }


            
            for (int i = 0; i < st.Count; i++)
            {
                if (st[i].Equals("("))
                {
                    count++;
                }
                else
                {

                    // It is a closing parenthesis  
                    count--;
                }
                if (count < 0)
                {

                     
                    balanced = false;
                    break;
                }
            }

          
            if (count != 0)
            {
                balanced = false;
            }
            Console.WriteLine(balanced);
            return balanced;
        }

        //5

        public static int CountVariantsUtil(int n)
        {
            int[] res = new int[n];
            res[0] = 1;
            res[1] = 1;
            for (int i = 2; i < n; i++)
            {
                res[i] = 0;
                for (int j = 1; j <= 2 && j <= i; j++)
                    res[i] += res[i - j];
            }

            return res[n - 1];
        }

        public static int CountVariants(int stearsCount)
        {
            return CountVariantsUtil(stearsCount + 1);
        }



        //8

        public static double ExchangeRate(string from , string to)
        {
            double rate=0;

            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>
            {
                { "AED", 0.89028 },
                { "AMD", 0.0062505 },
                { "AUD", 2.4868 },
                { "AZN", 1.9248 },
                { "BGN", 2.035 },
                { "BRL", 0.6268 },
                { "BYN", 1.2648 },
                { "CAD", 2.5417 },
                { "CHF", 3.6749 },
                { "CNY", 0.50031 },
                { "CZK", 0.15194 },
                { "DKK", 0.53592 },
                { "EGP", 0.20827 },
                { "EUR", 3.987 },
                { "GBP", 4.434 },
                { "HKD", 0.42172 },
                { "HUF", 0.010992 },
                { "ILS", 1.01581 },
                { "INR", 0.044459 },
                { "IRR", 0.00007785 },
                { "ISK", 0.025552 },
                { "JPY", 0.031615 },
                { "KGS", 0.038641 },
                { "KRW", 0.0029695 },
                { "KWD", 10.7069 },
                { "KZT", 0.007796 },
                { "MDL", 0.18953 },
                { "NOK", 0.37899 },
                { "NZD", 2.3272 },
                { "PLN", 0.8849 },
                { "QAR", 0.88704 },
                { "RON", 0.81778 },
                { "RSD", 0.033863 },
                { "RUB", 0.044255 },
                { "SEK", 0.39546 },
                { "SGD", 2.4593 },
                { "TJS", 0.28937 },
                { "TMT", 0.93426 },
                { "TRY", 0.4333 },
                { "UAH", 0.11528 },
                { "USD", 3.2699 },
                { "UZS", 0.0003122 },
                { "ZAR", 0.22376 },

            };

            
            double fr = keyValuePairs[from];
            double toconvert = keyValuePairs[to];
            rate = fr / toconvert;

            Console.WriteLine(rate);
            return rate;

        }

    }



    


        class Program
    {
        static void Main(string[] args)
        {
            //Davaleba.Ispalindrome("nh");
            //Davaleba.MinSplit(101);

            //int[] arr = {5, 3,6,7 };
            //Davaleba.NotContains(arr);
            //Davaleba.IsProperly("(fed))");
           //Console.WriteLine(Davaleba.CountVariantsUtil(5));
            Davaleba.ExchangeRate("USD", "EUR");
            
            //Davaleba.IsProperly("()fjekd()");
            Console.ReadLine();
        }
    }
}
