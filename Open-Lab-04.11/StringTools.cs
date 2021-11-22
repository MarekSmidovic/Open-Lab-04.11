using System;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char temp;
            str = str.ToLower();
            char[] charstr = str.ToCharArray();
            for (int i = 1; i < charstr.Length; i++)    // for(int i=1;i< str.Length;i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)  //for(int j=0;j< str.Length-1;j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
            string a = charstr.ToString();
            return a;
        }
    }
}
