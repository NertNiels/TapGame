using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace TapGame.UI
{
    class Button : View
    {
        public int texId;
        public Texture2D textureIdle { get { return TextureManager.textures[texId]; } }
        public Texture2D texturePressed { get { return TextureManager.textures[texId + 1]; } }

        public Button(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public override void update(GameTime gameTime)
        {
        }

        public override void draw(SpriteBatch spriteBatch)
        {
            if(pressed) spriteBatch.Draw(textureIdle, bound, Color.LightGray);
            else spriteBatch.Draw(textureIdle, bound, Color.White);
        }

        
    }
}
