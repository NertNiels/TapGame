using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace TapGame
{
    class TextureManager
    {
        public static Texture2D[] textures;

        public static Texture2D WHITE_SQUARE { get { return textures[0]; } }
        public static Texture2D OFFICE_1_DEMO { get { return textures[1]; } }


        public static void initialize(GraphicsDevice graphics, ContentManager content) {

            textures = new Texture2D[2];

            textures[0] = new Texture2D(graphics, 1, 1);
            textures[0].SetData(new Color[] { Color.White });
            
            textures[1] = content.Load<Texture2D>("Office/Office_1_demo");
        }
    }

    class FontManager
    {
        public static SpriteFont[] fonts;

        public static SpriteFont DEFAULT { get { return fonts[0]; } }

        public static void initialize(ContentManager content)
        {
            fonts = new SpriteFont[1];

            fonts[0] = content.Load<SpriteFont>("Font/Default");
        }
    }
}
