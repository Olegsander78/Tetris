using System;
using System.Threading;

namespace Tetris
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            FigureGenerator generator = new FigureGenerator(20, 0, '#');
            Figure s=null;


            while (true)
            {
                FigureFall(s,generator);
                s.Draw();
            }

            static void FigureFall(Figure fig, FigureGenerator figureGenerator)
            {
                fig = figureGenerator.GetNewFigure();
                fig.Draw();

                for (int i = 0; i < 15; i++)
                {
                    Thread.Sleep(500);
                    fig.Hide();
                    fig.Move(Direction.DOWN);
                    fig.Draw();
                }
            }

            //s.Draw();
            //Thread.Sleep(500);
            
            //s.Hide();
            //s.Rotate();
            //s.Draw();

            //Thread.Sleep(500);
            //s.Hide();
            //s.Move(Direction.DOWN);
            //s.Draw();

            //Thread.Sleep(500);
            //s.Hide();
            //s.Move(Direction.RIGTH);
            //s.Draw();

            //Thread.Sleep(500);
            //s.Hide();
            //s.Rotate();
            //s.Draw();

            //Figure[] f = new Figure[2];
            //f[0]= new Square(2, 5, '*');
            //f[1]= new Stick(6, 6, '#');

            //foreach (var item in f)
            //{
            //    item.Draw();
            //}


            Console.ReadLine();
        }

        
    }
}
