using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TapGame.UI
{
    public abstract class View
    {
        public delegate void onClickListener(TouchEvent e);
        public delegate void onTouchListener(TouchEvent e);

        private List<onClickListener> onClickListeners;
        private List<onTouchListener> onTouchListeners;

        public int width;
        public int height;
        public int x;
        public int y;

        public Rectangle bound { get { return new Rectangle(x, y, width, height); } }

        public bool pressed = false;
        public bool isDrawed = true;
        
        public View()
        {
            onClickListeners = new List<onClickListener>();
            onTouchListeners = new List<onTouchListener>();
        }

        public Boolean onTouch(TouchEvent e)
        {
            if (bound.Contains(e.X, e.Y))
            {
                if (e.State == TouchState.Released)
                {
                    foreach(onClickListener listener in onClickListeners)
                    {
                        listener(e);
                    }
                    pressed = false;
                    return true;
                }
                foreach (onTouchListener listener in onTouchListeners)
                {
                    listener(e);
                }
                pressed = true;
                return true;
            }
            pressed = false;
            return false;
        }

        public abstract void update(GameTime gameTime);
        public abstract void draw(SpriteBatch spriteBatch);

        public void addOnClickListener(onClickListener listener) { onClickListeners.Add(listener); }
        public void addOnTouchListener(onTouchListener listener) { onTouchListeners.Add(listener); }
    }
}
