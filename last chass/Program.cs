namespace last_chass
{
    internal class Program
    {
        enum Figur
        {
            k,
            q,
            b,
            r,
            n,
            p
        }
        class King
        {
            public int numberForKing;
            public char letterForKing;
            public char[] letterSForKing = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            public void kingIsMoving(ref int inputNum, ref char inputLet)
            {
                do/*nayuma tagavory kara gna et tvov texy te che*/
                {
                    Console.WriteLine("Enter number wher to move ");
                    numberForKing = int.Parse(Console.ReadLine());
                    if (numberForKing == inputNum || numberForKing + 1 == inputNum || numberForKing - 1 == inputNum)
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                } while (true);
                do /*senc tarnenq tali*/
                {
                    Console.WriteLine("enter letter where to move");
                    letterForKing = Console.ReadKey().KeyChar;
                    if (Array.IndexOf(letterSForKing, letterForKing) == Array.IndexOf(letterSForKing, inputLet) || Array.IndexOf(letterSForKing, letterForKing) + 1 == Array.IndexOf(letterSForKing, inputLet) || Array.IndexOf(letterSForKing, letterForKing) - 1 == Array.IndexOf(letterSForKing, inputLet))
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine();

                    }

                } while (true);
                inputNum = numberForKing; inputLet = letterForKing;
            }
        }
        class Queen
        {
            public int numberForQueen;
            public char[] letterSForQueen = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            public char letterForQueen;

            public void queenIsMoving(ref int inputNum, ref char inputLet)
            {
                do /*tivy kara luboy lini*/
                {
                    Console.WriteLine("Enter number where to move ");
                    numberForQueen = int.Parse(Console.ReadLine());
                } while (numberForQueen < 1 || numberForQueen > 8);
                do
                {
                    Console.WriteLine("enter letter where to move");
                    letterForQueen = Console.ReadKey().KeyChar;
                    /*araji ify horizonakan dirqov kara gna sax tarerov baci vori vra ka*/
                    if (numberForQueen == inputNum && Array.IndexOf(letterSForQueen, letterForQueen) != Array.IndexOf(letterSForQueen, inputLet))
                    {
                        Console.WriteLine();
                        break;
                    }
                    /*uxxahayaca etum nuyn cev*/
                    else if (numberForQueen != inputNum && Array.IndexOf(letterSForQueen, letterForQueen) == Array.IndexOf(letterSForQueen, inputLet))
                    {
                        Console.WriteLine();
                        break;
                    }
                    /*diaganalov*/
                    else if (Math.Abs(numberForQueen - inputNum) == Math.Abs(Array.IndexOf(letterSForQueen, letterForQueen) - Array.IndexOf(letterSForQueen, inputLet)))
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        do /*tivy kara luboy lini*/
                        {
                            Console.WriteLine("Enter number where to move ");
                            numberForQueen = int.Parse(Console.ReadLine());
                        } while (numberForQueen < 1 || numberForQueen > 8);

                    }
                } while (true);
                inputNum = numberForQueen;
                inputLet = letterForQueen;
            }
        }
        class Bishop
        {
            public int numberForBishop;
            public char letterForBishop;
            public char[] letterSForBishop = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            public void BishopIsMoving(ref int inputNum, ref char inputLet)
            {
                do /*tivy kara luboy lini*/
                {
                    Console.WriteLine("Enter number where to move ");
                    numberForBishop = int.Parse(Console.ReadLine());
                } while (numberForBishop < 1 || numberForBishop > 8);
                do
                {
                    Console.WriteLine("enter letter where to move");
                    letterForBishop = Console.ReadKey().KeyChar;
                    if (Math.Abs(numberForBishop - inputNum) == Math.Abs(Array.IndexOf(letterSForBishop, letterForBishop) - Array.IndexOf(letterSForBishop, inputLet)))
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        do /*tivy kara luboy lini*/
                        {
                            Console.WriteLine("Enter number where to move ");
                            numberForBishop = int.Parse(Console.ReadLine());
                        } while (numberForBishop < 1 || numberForBishop > 8);

                    }
                } while (true);
                inputNum = numberForBishop;
                inputLet = letterForBishop;
            }
        }
        class Rook
        {
            public int numberForRook;
            public char letterForRook;
            public char[] letterSForRook = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            public void RookIsMoving(ref int inputNum, ref char inputLet)
            {
                do /*tivy kara luboy lini*/
                {
                    Console.WriteLine("Enter number where to move ");
                    numberForRook = int.Parse(Console.ReadLine());
                } while (numberForRook < 1 || numberForRook > 8);
                do
                {
                    Console.WriteLine("enter letter where to move");
                    letterForRook = Console.ReadKey().KeyChar;
                    /*araji ify horizonakan dirqov kara gna sax tarerov baci vori vra ka*/
                    if (numberForRook == inputNum && Array.IndexOf(letterSForRook, letterForRook) != Array.IndexOf(letterSForRook, inputLet))
                    {
                        Console.WriteLine();
                        break;
                    }
                    /*uxxahayaca etum nuyn cev*/
                    else if (numberForRook != inputNum && Array.IndexOf(letterSForRook, letterForRook) == Array.IndexOf(letterSForRook, inputLet))
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        do /*tivy kara luboy lini*/
                        {
                            Console.WriteLine("Enter number where to move ");
                            numberForRook = int.Parse(Console.ReadLine());
                        } while (numberForRook < 1 || numberForRook > 8);
                    }
                } while (true);
                inputNum = numberForRook;
                inputLet = letterForRook;
            }
        }
        class night
        {
            public int numberForNight;
            public char letterForNight;
            public char[] letterSForNight = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            public void NightIsMoving (ref int inputNum, ref char inputLet)
            {
                do /*tivy kara  lini baci irranic 2 hat verev 2 hat nerqev*/
                {
                    Console.WriteLine("Enter number where to move ");
                    if(!int.TryParse(Console.ReadLine(),out numberForNight))
                    {
                        Console.WriteLine("enter right number");
                    }
                    
                } while (numberForNight == inputNum  || Math.Abs(numberForNight - inputNum) > 2) ;
                do
                {
                    Console.WriteLine("enter letter where to move");
                    letterForNight = Console.ReadKey().KeyChar;
                    
                    if(Math.Abs(numberForNight - inputNum) == 2 && Math.Abs(Array.IndexOf(letterSForNight, letterForNight) - Array.IndexOf(letterSForNight, inputLet)) == 1)
                    {
                        Console.WriteLine();
                        break;
                    }
                    if (Math.Abs(numberForNight - inputNum) == 1 && Math.Abs(Array.IndexOf(letterSForNight, letterForNight) - Array.IndexOf(letterSForNight, inputLet)) == 2)
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        do 
                        {
                            Console.WriteLine("Enter number where to move ");
                            numberForNight = int.Parse(Console.ReadLine());
                        } while (numberForNight == inputNum || Math.Abs(numberForNight - inputNum) > 2);
                    }
                } while (true);
                inputNum = numberForNight;
                inputLet = letterForNight;
            }
        }



        public struct Point
        {

            public int number;
            public char letter;
            public Point(int num, char let)
            {
                number = num;
                letter = let;
            }
        }
        static void makingChase(int inputNum, char inputLet, string inputFigur)
        {
            int[,] boardSize = new int[10, 10];
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0 && i < 8)/*tverna tpum*/
                    {
                        Console.Write(8 - i);
                    }
                    else if (i == 8 && j >= 0)/*tareri hamra*/
                    {
                        Console.Write($"  {letters[j]}");
                    }
                    if ((i + j) % 2 == 0 && i < 8)
                    {

                        Console.BackgroundColor = ConsoleColor.White;

                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    if (8 - i == inputNum && letters[j] == inputLet) /*nayuma koordinatnery hamynknuma*/
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(inputFigur + "  ");
                    }
                    else if (i != 8 && j >= 0)
                    {
                        Console.Write("   ");
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        public static void FigurGattintPoint(int inputNum, char inputLet, string inputFigur)
        {
            
            Figur figur = (Figur)Enum.Parse(typeof(Figur), inputFigur);
            switch (figur)
            {
                case Figur.k:
                    King redKing = new King();
                    makingChase(inputNum, inputLet, inputFigur);
                    do
                    {
                        redKing.kingIsMoving(ref inputNum, ref inputLet);
                        makingChase(redKing.numberForKing, redKing.letterForKing, inputFigur);
                    } while (true);


                    break;
                case Figur.q:
                    Queen redQueen = new Queen();
                    makingChase(inputNum, inputLet, inputFigur);
                    do
                    {
                        redQueen.queenIsMoving(ref inputNum, ref inputLet);/*refov em tve vor es tivy hety beri. aranc sra nuynner mnum  */
                        makingChase(redQueen.numberForQueen, redQueen.letterForQueen, inputFigur);/*ese clasic ogtvelov*/
                    } while (true);

                    break;
                case Figur.b:/*queen ic vercrel em diaganlov qaylely. bishopIsmoving i mej */
                    Bishop redBishop = new Bishop();
                    makingChase(inputNum, inputLet, inputFigur);
                    do
                    {
                        redBishop.BishopIsMoving(ref inputNum, ref inputLet);
                        makingChase(redBishop.numberForBishop, redBishop.letterForBishop, inputFigur);
                    } while (true);

                    break;
                case Figur.r:
                    Rook redRook = new Rook();
                    makingChase(inputNum, inputLet, inputFigur);
                    do
                    {
                        redRook.RookIsMoving(ref inputNum, ref inputLet);
                        makingChase(redRook.numberForRook, redRook.letterForRook, inputFigur);
                    } while (true);
                    break;
                case Figur.n:
                    night redNight = new night();

                    makingChase(inputNum, inputLet, inputFigur);
                    do
                    {
                        redNight.NightIsMoving(ref inputNum, ref inputLet);
                        makingChase(redNight.numberForNight, redNight.letterForNight, inputFigur);
                    } while (true);
                    break;
                case Figur.p:
                    makingChase(inputNum, inputLet, inputFigur);
                    break;
                default:
                    break;
            }


        }
        static void Main(string[] args)
        {
            int number;
            char letter;
            string figur;
            
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            do
            {
                Console.WriteLine("Enter number ");
                number = int.Parse(Console.ReadLine());
            } while (number < 1 || number > 8);
            do
            {
                Console.WriteLine("enter letter");
                letter = Console.ReadKey().KeyChar;
                if (Array.IndexOf(letters, letter) != -1)
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine();
                }

            } while (true);
            do
            {
                Console.WriteLine("Enter your figur");
                figur = Console.ReadLine();
                Figur figurEnum = (Figur)Enum.Parse(typeof(Figur), figur);
            } while (false);
            FigurGattintPoint(number, letter, figur);

        }
    }
}
