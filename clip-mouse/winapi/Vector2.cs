using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace clip_mouse.winapi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2
    {
        public int X;
        public int Y;

        public Vector2(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return String.Format("Vector2 ({0}, {1})", X, Y);
        }
    }
}
