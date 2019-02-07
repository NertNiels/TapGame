using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using TapGame.UI;

namespace TapGame.Game
{
    class Room
    {
        public static int RoomHeight { get { return (int)(RoomWidth * 2f); } }
        public static int RoomWidth = 300;
        
        public Button boundsButton;

        public Room(RoomSide roomSide, int indexFromUnder, UIManager ui)
        {
            int x = 0;
            if (roomSide == RoomSide.Right) x = Main.WIDTH-RoomWidth;

            int y = Main.HEIGHT -(RoomHeight * (indexFromUnder+1)) - RoomHeight;

            boundsButton = new Button(x, y, RoomWidth, RoomHeight, true);
            ui.addView(boundsButton);
        }

        public void update(GameTime gameTime)
        {
            
        }

        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(TextureManager.WHITE_SQUARE, boundsButton.bound, Color.DimGray);
        }
    }

    enum RoomSide
    {
        Left,
        Right
    }
}
