using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace TapGame.Game
{
    public class GameManager
    {
        private List<Room> leftOffices, rightOffices;

        public UIManager UIManager;

        public GameManager(UIManager ui)
        {
            this.UIManager = ui;

            Room.RoomWidth = Main.WIDTH / 3;

            leftOffices = new List<Room>();
            rightOffices = new List<Room>();

            addLeftOffice(UIManager);

            addRightOffice(UIManager);
            addRightOffice(UIManager);
        }
        

        public void update(GameTime gameTime)
        {
            foreach (Room r in leftOffices) r.update(gameTime);
            foreach (Room r in rightOffices) r.update(gameTime);

        }

        public void draw(SpriteBatch spriteBatch)
        {
            foreach (Room r in leftOffices) r.draw(spriteBatch);
            foreach (Room r in rightOffices) r.draw(spriteBatch);
        }

        public void addLeftOffice(UIManager ui)
        {
            leftOffices.Add(new Room(RoomSide.Left, leftOffices.Count, ui));
        }

        public void addRightOffice(UIManager ui)
        {
            rightOffices.Add(new Room(RoomSide.Right, rightOffices.Count, ui));
        }
    }
}
