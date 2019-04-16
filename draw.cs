using System;
using SplashKitSDK;

namespace SnakesAndLadders
{ 
    public class DrawMethod
    {
        public static void Draw(Player play)
        {
            Window gameWindow;
            Bitmap mapPng;
            Bitmap player;

            mapPng = new Bitmap("Snakes and Ladders Board","board800.png");
            gameWindow = new Window("Game Window",1400,800);
            player = new Bitmap("Player Character","smalldonny.png");

            gameWindow.Clear(Color.White);
            gameWindow.DrawBitmap(mapPng,0,0);
            gameWindow.Refresh();
            gameWindow.DrawBitmap(player,play.CoorX,play.CoorY);
            // gameWindow.DrawBitmap(player,0,0);
            gameWindow.Refresh();
            SplashKit.Delay(15000);
        }
    }
}