using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TapGame
{
    class TextureManager
    {
        public static Texture2D WHITE_SQUARE;

        public static void initialize(GraphicsDevice graphics) {
            WHITE_SQUARE = new Texture2D(graphics, 1, 1);
            WHITE_SQUARE.SetData(new Color[] { Color.White });
        }
    }
}
