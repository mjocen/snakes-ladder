using System;
using SplashKitSDK;

namespace SnakesAndLadders
{
    public class Program
    {
        public static void Main()
        {
            Player player1 = new Player("Jo", 40, 760);
            bool con = true;
            while(con)
            {
                DrawMethod.Draw(player1);
                SplashKit.ProcessEvents();
                if(SplashKit.KeyDown( KeyCode.PKey))
                {
                    int die = player1.Dice();
                    for (int i=0; i< die; i++)
                    {
                        player1.Move();
                    }
                    player1.LadderRise();
                    player1.SnakeBite();
                }

                DrawMethod.Draw(player1);

                if(player1.CoorX < 80 && player1.CoorY < 80)
                {
                    con = false;
                }

            }
        }

    }
}