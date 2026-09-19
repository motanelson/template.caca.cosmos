using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Cosmos.System.Graphics;
using Sys = Cosmos.System;

namespace Cosmosvga
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            graf.starts();
        }

        protected override void Run()
        {
            while (true)
            {
                lines.Main();
                var input = Console.ReadLine();


            }


        }
    }
    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;

        public static void Points(int x, int y)
        {


            Pen p = new Pen(Color.FromArgb(0, 0, 0));
            canvas.DrawPoint(p, x, y);





        }
        public static void hlines(int x, int y, int x1)
        {

            int i = 0;
            for (int j = x; j < x1; j++) Points(j, y);


        }
        public static void vline(int x, int y, int y1)
        {

            int i = 0;
            for (int j = y; j < y1; j++) Points(x, j);



        }

        public static void box(int x, int y, int x1, int y1)
        {

            for (int j = y; j < y1; j++) hlines(x, j, x1);


        }
        public static void starts()
        {


            canvas= FullScreenCanvas.GetFullScreenCanvas(new Mode(640, 480, ColorDepth.ColorDepth32));
            Sys.MouseManager.ScreenHeight = (uint)(470);
            Sys.MouseManager.ScreenWidth = (uint)(630);




        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }






    class tests



    {


        public static void mainLoop()
        {
            //

            
            graf.cls(Color.White);
            for (int i = 0; i < 639; i = i + 10)
            {
                graf.hlines(0, i, 639);
                graf.vline(i, 0, 479);

            }

            graf.displays();
        }



    }



    class lines
    {

        public static void Main()
        {
            tests.mainLoop();



        }



    }


}
