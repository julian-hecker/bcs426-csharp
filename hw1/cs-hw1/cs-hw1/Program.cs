using System;

namespace cs_hw1
{
    class Hw1
    {
        public static void Triangle()
        {
            Console.WriteLine("What character should be used?");
            char character = Console.ReadLine()[0];

            Console.WriteLine("How many lines do you want in your triangle?");
            int lines = Convert.ToInt32(Console.ReadLine());

            string output = "";

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < lines - i / 2; j++)
                {
                    output += ' ';
                }
                for (int j = 0; j < i; j++)
                {
                    output += character;
                }
                output += '\n';
            }
            Console.WriteLine(output);
        }


        public static void Diamond()
        {
            Console.WriteLine("What character should be used?");
            char character = Console.ReadLine()[0];

            Console.WriteLine("How many lines do you want in your rhombus?");
            int lines = Convert.ToInt32(Console.ReadLine());

            string output = "";

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < lines - i / 2; j++)
                {
                    output += ' ';
                }
                for (int j = 0; j < i; j++)
                {
                    output += character;
                }
                output += '\n';
            }

            for (int i = lines - 1; i > 0; i--)
            {
                for (int j = 0; j < lines - i / 2; j++)
                {
                    output += ' ';
                }
                for (int j = 0; j < i; j++)
                {
                    output += character;
                }
                output += '\n';
            }



            Console.WriteLine(output);

        }


        public static void Reverse()
        {
            Console.WriteLine("What is your number?");
            string input = Console.ReadLine();
            string result = input;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            Console.WriteLine(result);
        }

        public static bool ValidatePassword()
        {
            Console.WriteLine("What is your password? Promise not to steal.");
            string password = Console.ReadLine();

            if (password.Length < 6 || password.Length > 15)
            {
                Console.WriteLine("Length should be 6-15 chars");
                return false;
            }

            bool digit = false;
            bool special = false;
            bool upper = false;
            bool lower = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i]))
                {
                    upper = true;
                }
                if (Char.IsLower(password[i]))
                {
                    lower = true;
                }
                if (Char.IsDigit(password[i]))
                {
                    digit = true;
                }
                switch (password[i])
                {
                    case '!':
                    case '@':
                    case '#':
                    case '$':
                    case '%':
                    case '^':
                    case '&':
                    case '*':
                    case '(':
                    case ')':
                    case '+':
                    case '=':
                    case '_':
                    case '-':
                    case '{':
                    case '}':
                    case '[':
                    case ']':
                    case ':':
                    case ';':
                    case '"':
                    case '\'':
                    case '?':
                    case '<':
                    case '>':
                    case ',':
                    case '.':
                        special = true;
                        break;
                }
            }
            if (!digit)
            {
                Console.WriteLine("You must include at least one digit");
            }
            if (!special)
            {
                Console.WriteLine("You must include at least one special character");
            }
            if (!upper)
            {
                Console.WriteLine("You must include at least one uppercase character");
            }
            if (!lower)
            {
                Console.WriteLine("You must include at least one lowercase character");
            }

            if (digit && special && upper && lower)
            {
                Console.WriteLine("Congratulations, password approved!");
                return true;
            }
            else
            {
                Console.WriteLine("Please make above fixes and try again");
                return false;
            }
        }

        public static void Main()
        {
            Triangle();
            Diamond();
            Reverse();
            ValidatePassword();

            Console.ReadLine();
        }

    }
    /*  Comments
    *   Getting Visual Studio installed last minute was a mess, it took nearly a whole hour.
    *   The programs were quite challenging but entertaining to work on. Reading documentation for a new language in order to solve a problem quickly is always fun.
    *   All I've got for now! -- Julian Hecker
    */
}
