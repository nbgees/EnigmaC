using System;

namespace EnigmaTest2
{
    class Program
    {
        static char[] rot1d = { 'D', 'M', 'T', 'W', 'S', 'I', 'L', 'R', 'U', 'Y', 'Q', 'N', 'K', 'F', 'E', 'J', 'C', 'A', 'Z', 'B', 'P', 'G', 'X', 'O', 'H', 'V' };
        static char[] rot2d = { 'H', 'Q', 'Z', 'G', 'P', 'J', 'T', 'M', 'O', 'B', 'L', 'N', 'C', 'I', 'F', 'D', 'Y', 'A', 'W', 'V', 'E', 'U', 'S', 'R', 'K', 'X' };
        static char[] rot3d = { 'U', 'Q', 'N', 'T', 'L', 'S', 'Z', 'F', 'M', 'R', 'E', 'H', 'D', 'P', 'X', 'K', 'I', 'B', 'V', 'Y', 'G', 'J', 'C', 'W', 'O', 'A' };
        static char[] rot4d = { 'L', 'E', 'Y', 'J', 'V', 'C', 'N', 'I', 'X', 'W', 'P', 'B', 'Q', 'M', 'D', 'R', 'T', 'A', 'K', 'Z', 'G', 'F', 'U', 'H', 'O', 'S' };
        static char[] rot5d = { 'F', 'S', 'O', 'K', 'A', 'N', 'U', 'E', 'R', 'H', 'M', 'B', 'T', 'I', 'Y', 'C', 'W', 'L', 'Q', 'P', 'Z', 'X', 'V', 'G', 'J', 'D' };
        static char[] rotor1 = rot1d;
        static char[] rotor2 = rot2d;
        static char[] rotor3 = rot2d;
        static char[] temp = new char[26];
        static char rot1char, rot2char, rot3char;
        static int r1m, r2m, r3m = 0;
        static string output, Input = "";

        static void Main(string[] args)
        {
            while (true)
            {
                char[] rot1d = { 'D', 'M', 'T', 'W', 'S', 'I', 'L', 'R', 'U', 'Y', 'Q', 'N', 'K', 'F', 'E', 'J', 'C', 'A', 'Z', 'B', 'P', 'G', 'X', 'O', 'H', 'V' };
                char[] rot2d = { 'H', 'Q', 'Z', 'G', 'P', 'J', 'T', 'M', 'O', 'B', 'L', 'N', 'C', 'I', 'F', 'D', 'Y', 'A', 'W', 'V', 'E', 'U', 'S', 'R', 'K', 'X' };
                char[] rot3d = { 'U', 'Q', 'N', 'T', 'L', 'S', 'Z', 'F', 'M', 'R', 'E', 'H', 'D', 'P', 'X', 'K', 'I', 'B', 'V', 'Y', 'G', 'J', 'C', 'W', 'O', 'A' };
                char[] rot4d = { 'L', 'E', 'Y', 'J', 'V', 'C', 'N', 'I', 'X', 'W', 'P', 'B', 'Q', 'M', 'D', 'R', 'T', 'A', 'K', 'Z', 'G', 'F', 'U', 'H', 'O', 'S' };
                char[] rot5d = { 'F', 'S', 'O', 'K', 'A', 'N', 'U', 'E', 'R', 'H', 'M', 'B', 'T', 'I', 'Y', 'C', 'W', 'L', 'Q', 'P', 'Z', 'X', 'V', 'G', 'J', 'D' };
                rotor1 = rot1d; rotor2 = rot2d; rotor3 = rot2d;

                string command = Console.ReadLine();
                if (command.ToLower() == "clear")
                {
                    Console.Clear();
                }

                Console.Write("Rotor 1 (1-5)");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1: rotor1 = rot1d; break;
                    case 2: rotor1 = rot2d; break;
                    case 3: rotor1 = rot3d; break;
                    case 4: rotor1 = rot4d; break;
                    case 5: rotor1 = rot5d; break;
                    default: rotor1 = rot1d; break;
                }
                Console.Write("Rotor 2 (1-5)");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1: rotor2 = rot1d; break;
                    case 2: rotor2 = rot2d; break;
                    case 3: rotor2 = rot3d; break;
                    case 4: rotor2 = rot4d; break;
                    case 5: rotor2 = rot5d; break;
                    default: rotor2 = rot2d; break;
                }
                Console.Write("Rotor 3 (1-5)");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1: rotor3 = rot1d; break;
                    case 2: rotor3 = rot2d; break;
                    case 3: rotor3 = rot3d; break;
                    case 4: rotor3 = rot4d; break;
                    case 5: rotor3 = rot5d; break;
                    default: rotor3 = rot1d; break;
                }

                Console.Write("Rotor 1 posistion: ");
                char rot1to = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Rotor 2 posistion: ");
                char rot2to = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Rotor 3 posistion: ");
                char rot3to = char.Parse(Console.ReadLine().ToUpper());

                rot1char = rotor1[0];
                rot2char = rotor2[0];
                rot3char = rotor3[0];

                while (rot1char != rot1to) { r1(); }
                while (rot2char != rot2to) { r2(); }
                while (rot3char != rot3to) { r3(); }

                Console.Write("Message: ");
                Input = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Input = Input.Replace(" ", "");

                foreach (char c in Input)
                {
                    int cc = c - 65;
                    int c1 = rotor1[cc];
                    int c2 = rotor2[c1 - 65];
                    int c3 = rotor3[c2 - 65];
                    char refl = 'A';
                    int c4 = 0;
                    int c5 = 0;
                    int c6 = 0;
                    refl = (c3 < 78) ? (refl = (char)(c3 + 13)) : (refl = (char)(c3 - 13));
                    for (int i = 0; i < 26; i++) { if (rotor3[i] == (char)refl) { c4 = (char)(i + 65); } }
                    for (int i = 0; i < 26; i++) { if (rotor2[i] == (char)c4) { c5 = (char)(i + 65); } }
                    for (int i = 0; i < 26; i++) { if (rotor1[i] == (char)c5) { c6 = (char)(i + 65); } }
                    output += ((char)c6);
                    r1();
                    //int temp = rotor1[0];
                    //for (int i = 1; i < rotor1.Length; i++) { rotor1[i - 1] = rotor1[i]; }
                    //rotor1[rotor1.Length - 1] = (char)temp;
                    //rot1char = rotor1[0];
                    //r1m += 1;
                    //if (r1m > 26) { r1m = 0; r2(); }
                }
                Console.WriteLine(output);
                output = "";
            }
        }

        public static void r1()
        {
            int temp = rotor1[0];
            for (int i = 1; i < rotor1.Length; i++) { rotor1[i - 1] = rotor1[i]; }
            rotor1[rotor1.Length - 1] = (char)temp;
            rot1char = rotor1[0];
            r1m += 1;
            if (r1m > 26) { r1m = 0; r2(); }
        }

        public static void r2()
        {
            int temp = rotor2[0];
            for (int i = 1; i < rotor2.Length; i++) { rotor2[i - 1] = rotor2[i]; }
            rotor2[rotor2.Length - 1] = (char)temp;
            rot2char = rotor2[0];
            r2m += 1;
            if (r2m > 26) { r2m = 0; r3(); }
        }

        public static void r3()
        {
            int temp = rotor3[0];
            for (int i = 1; i < rotor3.Length; i++) { rotor3[i - 1] = rotor3[i]; }
            rotor3[rotor3.Length - 1] = (char)temp;
            rot3char = rotor3[0];
            r3m += 1;
            if (r3m > 26) { r3m = 0; }
        }
    }
}