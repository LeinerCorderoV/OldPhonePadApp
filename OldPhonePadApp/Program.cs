using System;
using System.Collections.Generic;
using System.Text;

namespace OldPhonePadApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Keys: 2=ABC 3=DEF 4=GHI 5=JKL 6=MNO 7=PQRS 8=TUV 9=WXYZ 0=space");
            Console.WriteLine("Use #: end, *: back, space: pause, q: quit\n");

            while (true)
            {
                Console.Write("Input> ");
                string input = Console.ReadLine()?.Trim();

                if (string.Equals(input, "q", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Bye!");
                    break;
                }

                if (string.IsNullOrEmpty(input) || !input.EndsWith("#"))
                {
                    Console.WriteLine("Error: sequence must end with '#'.\n");
                    continue;
                }

                bool invalid = false;
                foreach (char c in input)
                {
                    if (!char.IsDigit(c) && c != ' ' && c != '*' && c != '#')
                    {
                        invalid = true;
                        break;
                    }
                }
                if (invalid)
                {
                    Console.WriteLine("Error: only digits, space, '*' and '#' allowed.\n");
                    continue;
                }

                Console.WriteLine("Output> " + OldPhonePad(input) + "\n");
            }
        }

        // decode presses into text, '?' for invalid runs
        public static string OldPhonePad(string seq)
        {
            var map = new Dictionary<char, string>
            {
                ['2'] = "ABC",
                ['3'] = "DEF",
                ['4'] = "GHI",
                ['5'] = "JKL",
                ['6'] = "MNO",
                ['7'] = "PQRS",
                ['8'] = "TUV",
                ['9'] = "WXYZ",
                ['0'] = " "
            };

            var sb = new StringBuilder();
            int i = 0, n = seq.Length;

            while (i < n)
            {
                char c = seq[i];
                if (c == '#') break;
                if (c == ' ')
                {
                    i++; continue;               // pause
                }
                if (c == '*')
                {
                    if (sb.Length > 0) sb.Remove(sb.Length - 1, 1);
                    i++; continue;               // backspace
                }
                if (!map.ContainsKey(c))
                {
                    i++; continue;               // skip invalid
                }

                int j = i;
                while (j < n && seq[j] == c) j++;
                int run = j - i;                  // how many presses
                string letters = map[c];

                // valid press count?
                if (run >= 1 && run <= letters.Length)
                    sb.Append(letters[run - 1]);
                else
                    sb.Append('?');

                i = j;
            }

            return sb.ToString();
        }
    }
}

