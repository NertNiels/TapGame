using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TapGame.UI
{
    class Text : View
    {
        public string text;
        public Color color;

        public Text(string text, int x, int y, Color color, bool isDrawed = true)
        {
            this.text = text;
            this.color = color;

            this.x = x;
            this.y = y;

            this.isDrawed = isDrawed;
        }

        public Text(string text, int x, int y, bool isDrawed = true)
        {
            this.text = text;
            color = Color.White;

            this.x = x;
            this.y = y;

            this.isDrawed = isDrawed;
        }

        public Text(string text, int x, int y, Color color, float scale, bool isDrawed = true)
        {
            this.text = text;
            this.color = color;

            this.x = x;
            this.y = y;

            this.isDrawed = isDrawed;

            this.scale = scale;
        }

        public Text(string text, int x, int y, float scale, bool isDrawed = true)
        {
            this.text = text;
            color = Color.White;

            this.x = x;
            this.y = y;

            this.isDrawed = isDrawed;
            this.scale = scale;
        }

        public override void draw(SpriteBatch spriteBatch)
        {
            Vector2 offset = FontManager.DEFAULT.MeasureString(text) / 2;
            if (isDrawed) spriteBatch.DrawString(FontManager.DEFAULT, text, position - offset, color, 0f, Vector2.Zero, scale, SpriteEffects.None, 1f);
        }

        public override void update(GameTime gameTime)
        {

        }

        public void setText(string text)
        {
            this.text = text;
        }
    }
}
