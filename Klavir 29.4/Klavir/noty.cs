using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Klavir
{
    public class noty
    {
        Form1 Form1 { get; set; }
        public void Draw(Graphics g)
        {
            for (int i = 0; i <= 5; i++)
            {
                int space = 25 * i;
                Pen p = new Pen(Color.Black, 3);
                g.DrawLine(p, 0, 25 + space, 1000, 25 + space);
            }
            Pen bold = new Pen(Color.Gray, 10);
            g.DrawLine(bold, 25, 0, 25, 170);
            
        }
}
}
