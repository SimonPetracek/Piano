using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavir
{
    public class klavesy
    {
        public Graphics graphics { get; set; }
        public Form1 Form1 { get; set; }
        public int White { get; set; }
        public int FormWhiteSelector { get; set; }
        public int FormBlackSelector { get; set; }
        public int Black { get; set; }
        int[] pole = { 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0 };
        char[] pismenaWhite = { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'y', 'x', 'c', 'v', 'b', 'n', 'm', 'q', 'w', 'e', 'r', 't', 'z', 'u', 'i'};
        public klavesy()
        {

        }
        public void Draw(Graphics g)
        {
            for (int i = 0; i < White; i++)
            {
                int space = i * 40;
                Rectangle whiterec = new Rectangle(space, 0, 40, 200);
                g.FillRectangle(Brushes.White, whiterec);
                g.DrawRectangle(Pens.Black, whiterec);
                g.DrawString(pismenaWhite[i].ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), 15 + space, 180);
            }
            for (int i = 0; i < Black; i++)
            {
               if (pole[i]== 1)
                 {
                   int space = i * 40;
                   Rectangle blackrec = new Rectangle(25 + space, 0, 30, 130);
                   g.FillRectangle(Brushes.Black, blackrec);
                }
            }
        }
        public void SelectedWhiteKey(Graphics g)
        {
            for (int i = 0; i < White; i++)
            {
                if (i == this.FormWhiteSelector)
                {
                    int space = i * 40;
                    Rectangle whiterec = new Rectangle(space, 0, 40, 200);
                    g.FillRectangle(Brushes.Gray, whiterec);
                    g.DrawRectangle(Pens.Black, whiterec);
                    g.DrawString(pismenaWhite[i].ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), 15 + space, 180);
                }
                else
                {
                    int space = i * 40;
                    Rectangle whiterec = new Rectangle(space, 0, 40, 200);
                    g.FillRectangle(Brushes.White, whiterec);
                    g.DrawRectangle(Pens.Black, whiterec);
                    g.DrawString(pismenaWhite[i].ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), 15 + space, 180);
                }
            }
            for (int i = 0; i < Black; i++)
            {
                if (pole[i] == 1)
                {
                    int space = i * 40;
                    Rectangle blackrec = new Rectangle(25 + space, 0, 30, 130);
                    g.FillRectangle(Brushes.Black, blackrec);
                }
            }
        } 
        public void SelectedBlackKey(Graphics g)
        {
            for (int i = 0; i < White; i++)
            {
                int space = i * 40;
                Rectangle whiterec = new Rectangle(space, 0, 40, 200);
                g.FillRectangle(Brushes.White, whiterec);
                g.DrawRectangle(Pens.Black, whiterec);
                g.DrawString(pismenaWhite[i].ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), 15 + space, 180);
            }
        }
    }
}
