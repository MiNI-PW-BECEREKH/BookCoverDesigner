using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLab
{
    public interface IGraphics
    {
        void Draw(Graphics g, System.Object  c);

        Point Position { get; set; }

        
    }
}
