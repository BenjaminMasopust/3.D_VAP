using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Board board = new Board();
            char playerToken = 'O';

           
            while (!board.Win())
            {
                if (playerToken == 'O')
                    playerToken = 'X';
                else
                    playerToken = 'O';

                Console.Clear();
                board.Print();

                
                Console.WriteLine("Na tahu je hráč: " + playerToken);

                int x, y;

               
                do
       
        }
    }

    public class Board
    {
        public char[][] Layout;

        
        public Board()
        {
            Layout = new char[3][];
            for (int i = 0; i < 3; i++)
            {
                Layout[i] = new char[3];
            }
        }

        
        public void Print()
        {
            Console.WriteLine("#####");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("#" + new string(Layout[i]) + "#");
            }
            Console.WriteLine("#####");
        }

        
        public bool IsCellFree(int x, int y)
        {
            return Layout[y][x] == default(char);
        }

        
        public bool CheckRows()
        {
            if (Layout[0][0] == Layout[1][0] && Layout[1][0] == Layout[2][0] && Layout[2][0] != default(char)) return true;
            if (Layout[0][1] == Layout[1][1] && Layout[1][1] == Layout[2][1] && Layout[2][1] != default(char)) return true;
            return Layout[0][2] == Layout[1][2] && Layout[1][2] == Layout[2][2] && Layout[2][2] != default(char);
        }

        
        public bool CheckCols()
        {
            if (Layout[0][0] == Layout[0][1] && Layout[0][1] == Layout[0][2] && Layout[0][2] != default(char)) return true;
            if (Layout[1][0] == Layout[1][1] && Layout[1][1] == Layout[1][2] && Layout[1][2] != default(char)) return true;
            return Layout[2][0] == Layout[2][1] && Layout[2][1] == Layout[2][2] && Layout[2][2] != default(char);
        }

        
        public bool CheckDiags()
        {
            if (Layout[0][0] == Layout[1][1] && Layout[1][1] == Layout[2][2] && Layout[2][2] != default(char)) return true;
            return Layout[0][2] == Layout[1][1] && Layout[1][1] == Layout[2][0] && Layout[2][0] != default(char);
        }

        
        public void Play(int x, int y, char token)
        {
            Layout[y][x] = token;
        }

        
        public bool Win()
        {
            return CheckRows() || CheckCols() || CheckDiags();
        }
    }
}
