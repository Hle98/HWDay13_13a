using System;
using System.Collections.Generic;

namespace HWDay13_13a
{
    class Program
    {
        static void Main(string[] args)
        {
            var ls = new List<string> { "MTXAFEC", "AC", "TAEC", "MTAFEC", "TAC", "MITXAFEC", "A", "MTAEC","ITXAFEC" };
            ShrinkableWords(ls, "MITXAFEC");
        }
        static void ShrinkableWords(List<string> ls, string word)
        {
            var result = new Stack<string>();
            if (ShrinkableWords(ls, word, result))
            {
                Console.Write($"Yes, {word} is shrinkable.");
            }
            else
            {
                Console.Write($"No, {word} is unshrinkable.");
            }
        }
        static bool ShrinkableWords(List<string> ls, string word, Stack<string> result)
        {
            if (word.Length==0)
            {
                return true;
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (ls.Contains(word))
                {
                    result.Push(word[i].ToString());
                    if (ShrinkableWords(ls, word.Remove(i,1), result))
                    {
                        return true;
                    }
                    result.Pop();
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
            
            
            
