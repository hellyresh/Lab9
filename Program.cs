using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Lab9_Circles
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Paint());
            
        }
    }
    class Circle
    {
        Graphics gr;
        Random rand = new Random();
        int time;
        int x;
        int y;
        Pen outCircle, inCircle;
        int r = 0;

        public Circle(int t, Graphics gr, int maxX, int maxY)
        {
            t *= 100; //десятые секунды
            //рандомизация времени жизни: t - среднее время
            //время жизни принадлежит промежутку [t - t/2; t + t/2]
            time = t + rand.Next(t) - t/2; 
            this.gr = gr;
            x = rand.Next(maxX);
            y = rand.Next(maxY);
            outCircle = new Pen(Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255)), 2);
            inCircle = new Pen(Color.Black, 2);
        }


        public void Run()
        {
            //рандомизация времени зарождения окружности после 
            Thread.Sleep(rand.Next(time/2) * 10);

            for (int i = 50; i < time; i++)
            {
                gr.DrawEllipse(inCircle, x - r/2, y - r/2, r, r);
                r += 1;
                gr.DrawEllipse(outCircle, x - r/2, y - r/2, r, r);
                Thread.Sleep(10);
            }            
            gr.DrawEllipse(inCircle, x - r/2, y - r/2, r, r);
            Paint.counter--;
        }

    }
}
