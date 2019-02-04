using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TapGame
{
    class TextureManager
    {
        public static Texture2D[] textures;

        public static Texture2D WHITE_SQUARE { get { return textures[0]; } }


        public static void initialize(GraphicsDevice graphics) {
            textures = new Texture2D[1];

            textures[0] = new Texture2D(graphics, 1, 1);
            textures[0].SetData(new Color[] { Color.White });
        }
    }
}
