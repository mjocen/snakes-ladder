using System;
using SplashKitSDK;

namespace SnakesAndLadders
{ 
    public class DrawMethod
    {
        public static void Draw()
        {
            Window gameWindow;
            Bitmap mapPng;
            Bitmap player;

            mapPng = new Bitmap("Snakes and Ladders Board","board800.png");
            gameWindow = new Window("Game Window",1400,850);
            player = new Bitmap("Player Character","donny.gif");

            gameWindow.Clear(Color.White);
            gameWindow.DrawBitmap(mapPng,300,25);
            gameWindow.Refresh();

            gameWindow.DrawBitmap(player,300,720);
            gameWindow.Refresh();

            SplashKit.Delay(5000);
        }
    }
}