using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignerPDFViewer
{
    class Result
    {

        /*
         * Complete the 'designerPdfViewer' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY h
         *  2. STRING word
         */

        public static int designerPdfViewer(List<int> h, string word)
        {
            //total length of the input
            int n = word.Length;

            //new integer list to store the height value of each word
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                //take index value (in [0,25] ) each character of input string
                int c = word[i] % 97;

                //Add corresponding height of the integer index to list
                list.Add(h[c]);
            }

            int area = list.Max() * n;
            return area;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

            string word = Console.ReadLine();

            int result = Result.designerPdfViewer(h, word);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
