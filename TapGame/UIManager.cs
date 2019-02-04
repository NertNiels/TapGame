using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Text;
using TapGame.UI;

namespace TapGame
{
    class UIManager
    {

        List<View> views;

        public UIManager(List<View> views)
        {
            this.views = views;
        }
        public UIManager()
        {
            views = new List<View>();
        }

        public void addView(View view)
        {
            views.Add(view);
        }

        public void onTouch(TouchCollection touchCollection)
        {
            if(touchCollection.Count == 1)
            {
                TouchEvent e = new TouchEvent((int)touchCollection[0].Position.X, (int)touchCollection[0].Position.Y, (TouchState)touchCollection[0].State);

                for(int i = views.Count - 1; i > -1; i--) if(views[i].onTouch(e)) break;
            }
        }

        public void update(GameTime gameTime)
        {
            foreach(View view in views)
            {
                view.update(gameTime);
            }
        }

        public void draw(SpriteBatch spriteBatch)
        {
            foreach (View view in views)
            {
                view.draw(spriteBatch);
            }
        }

    }
}
