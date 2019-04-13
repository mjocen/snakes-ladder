using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Draw();
    }

    public static void Draw()
    {
        Window gameWindow;
        Bitmap mapPng;

        mapPng = new Bitmap("Snakes and Ladders Board","board800.png");
        gameWindow = new Window("Game Window",1400,850);

        gameWindow.Clear(Color.White);
        gameWindow.DrawBitmap(mapPng,300,25);
        gameWindow.Refresh();

        SplashKit.Delay(5000);
    }
}

