using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using TapGame.UI;

namespace TapGame.Game
{
    public class GameManager
    {
        private List<Room> leftOffices, rightOffices;

        public UIManager UIManager;

        int moneyAmount;
        Text moneyText;
        

        public GameManager(UIManager ui)
        {
            UIManager = ui;

            moneyText = new Text("amount of money", Main.WIDTH / 2, Main.HEIGHT / 16, Color.Black);
            ui.addView(moneyText);

            leftOffices = new List<Room>();
            rightOffices = new List<Room>();

            updateViewport();

            addLeftOffice(UIManager);

            addRightOffice(UIManager);
            addRightOffice(UIManager);
        }
        

        public void update(GameTime gameTime)
        {
            foreach (Room r in leftOffices) r.update(gameTime);
            foreach (Room r in rightOffices) r.update(gameTime);

            moneyAmount++;
            moneyText.setText("$" + moneyAmount);

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

        public void updateViewport()
        {
            Room.RoomWidth = Main.WIDTH / 3;

            foreach (Room r in leftOffices) r.updateViewport();
            foreach (Room r in rightOffices) r.updateViewport();
        }
    }
}
