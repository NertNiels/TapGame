using System;
using System.Collections.Generic;
using System.Text;

namespace TapGame.UI
{
    class TouchEvent
    {
        public int X, Y;
        public TouchState State;

        public TouchEvent(int X, int Y, TouchState State)
        {
            this.X = X;
            this.Y = Y;
            this.State = State;
        }
    }

    enum TouchState
    {
        Invalid,
        Moved,
        Pressed,
        Released
    }
}
