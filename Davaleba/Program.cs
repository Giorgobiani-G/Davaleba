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





    }


        class Program
    {
        static void Main(string[] args)
        {
            //Davaleba.Ispalindrome("nh");
            //Davaleba.MinSplit(101);

            //int[] arr = {5, 3,6,7 };
            //Davaleba.NotContains(arr);
            Davaleba.IsProperly("(fed))");
            //Davaleba.IsProperly("()fjekd()");
            Console.ReadLine();
        }
    }
}
