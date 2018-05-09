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
        int[] array = { 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0 };
        public char[] charWhite = { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Y', 'X', 'C', 'V', 'B', 'N', 'M', 'Q', 'W', 'E', 'R', 'T', 'Z', 'U', 'I'};
        string[] stringBlack = { "alt + q", "alt + w", "alt + e", "alt + r", "alt + t", "alt + z", "alt + u", "alt + i", "alt + o", "alt + p", "alt + a", "alt + s", "alt + d", "alt + f", "alt + g", "alt + h", "alt + j"}; 
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
                g.DrawString(charWhite[i].ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), 15 + space, 180);
            }
            for (int i = 0; i < Black; i++)
            {
               if (array[i]== 1)
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
                    g.DrawString(charWhite[i].ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), 15 + space, 180);
                }
                else
                {
                    int space = i * 40;
                    Rectangle whiterec = new Rectangle(space, 0, 40, 200);
                    g.FillRectangle(Brushes.White, whiterec);
                    g.DrawRectangle(Pens.Black, whiterec);
                    g.DrawString(charWhite[i].ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), 15 + space, 180);
                }
            }
            for (int i = 0; i < Black; i++)
            {
                if (array[i] == 1)
                {
                    int space = i * 40;
                    Rectangle blackrec = new Rectangle(25 + space, 0, 30, 130);
                    g.FillRectangle(Brushes.Black, blackrec);
                    
                }
            }
        } 
        public void SelectedBlackKey(Graphics g)
        {
            Brush Text = new SolidBrush(Color.FromArgb(33, 34, 35));
            for (int i = 0; i < White; i++)
            {
                int space = i * 40;
                Rectangle whiterec = new Rectangle(space, 0, 40, 200);
                g.FillRectangle(Brushes.White, whiterec);
                g.DrawRectangle(Pens.Black, whiterec);
                g.DrawString(charWhite[i].ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), 15 + space, 180);
            }
            for (int i = 0; i < Black; i++)
            {
                if (i == this.FormBlackSelector)
                {
                    if (array[i] == 1)
                    {
                        int space = i * 40;
                        Rectangle blackrec = new Rectangle(25 + space, 0, 30, 130);
                        g.FillRectangle(Brushes.Black, blackrec);
                    }
                }
                else
                {
                    if (array[i] == 1)
                    {
                        int space = i * 40;
                        Rectangle blackrec = new Rectangle(25 + space, 0, 30, 130);
                        g.FillRectangle(Text, blackrec);
                    }
                }
            }
        }
    }
}
