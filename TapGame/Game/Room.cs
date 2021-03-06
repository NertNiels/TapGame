﻿using Microsoft.Xna.Framework;
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

        public RoomSide roomSide;
        public int indexFromUnder;
        public Button boundsButton;

        public Room(RoomSide roomSide, int indexFromUnder, UIManager ui)
        {
            this.roomSide = roomSide;
            this.indexFromUnder = indexFromUnder;

            boundsButton = new Button(0, 0, RoomWidth, RoomHeight, false);
            updateViewport();
            ui.addView(boundsButton);
        }

        public void update(GameTime gameTime)
        {
            
        }

        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(TextureManager.OFFICE_1_DEMO, boundsButton.bound, Color.White);
        }

        public void updateViewport()
        {
            int x = 0;  
            if (roomSide == RoomSide.Right) x = Main.WIDTH-RoomWidth;

            int y = Main.HEIGHT -(RoomHeight * (indexFromUnder+1)) - RoomHeight;

            boundsButton.x = x;
            boundsButton.y = y;
            boundsButton.width = RoomWidth;
            boundsButton.height = RoomHeight;

        }
    }

    enum RoomSide
    {
        Left,
        Right
    }
}
