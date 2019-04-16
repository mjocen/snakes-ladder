using System;
using System.Collections.Generic;
using System.Text;
// using SplashKitSDK;

namespace SnakesAndLadders
{
    public class Player
    {
        const int PLAYER_MOVE = 80;
        const int BOARD_MAX_EDGE = 800;

        private string _Player_name;
        public string Player_name
        {
            get { return _Player_name; }
        }

        private int _CoorX;
        public int CoorX

        {
            get { return _CoorX; }
        }

        private int _CoorY;
        public int CoorY
        {
            get { return _CoorY; }
        }

        // private Bitmap _Character;
        // public Bitmap Character
        // {
        //     get { return _Character; }
        // }

        public Player(string name, int x, int y)
        {
            _Player_name = name;    //"player1";
            _CoorX = x;             //40
            _CoorY = y;             //760;
            // _Character = character;
        }

        public int Dice()
        {
            return new Random().Next(7);
        }

        public void Move()
        {
            if(CheckY() && this._CoorX < BOARD_MAX_EDGE)
            {
                this._CoorX += PLAYER_MOVE;
            }
            else if (CheckY()==false && this._CoorX > BOARD_MAX_EDGE)
            {
                this._CoorX = 760;
                this._CoorY += PLAYER_MOVE;
            }
            else
            {
                Console.WriteLine("error in move coordinates");
            }
        }

        public bool CheckY()
        {
            if (this.CoorY > 720)
            {
                return true;
            }
            else if (this.CoorY > 560 && this.CoorY < 640)
            {
                return true;
            }
            else if (this.CoorY > 400 && this.CoorY < 480)
            {
                return true;
            }
            else if (this.CoorY > 240 && this.CoorY < 320)
            {
                return true;
            }
            else if (this.CoorY > 80 && this.CoorY < 160)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LadderRise()
        {
            int[][] ladder_bot = new int[8][];
            int[][] ladder_top = new int[8][];

            ladder_bot[0] = new int[2] { 280, 760 };
            ladder_bot[1] = new int[2] { 680, 760 };
            ladder_bot[2] = new int[2] { 200, 680 };
            ladder_bot[3] = new int[2] { 40, 600 };
            ladder_bot[4] = new int[2] { 600, 600 };
            ladder_bot[5] = new int[2] { 760, 360 };
            ladder_bot[6] = new int[2] { 760, 200 };
            ladder_bot[7] = new int[2] { 200, 200 };

            ladder_top[0] = new int[2] { 520, 680 };
            ladder_top[1] = new int[2] { 760, 520 };
            ladder_top[2] = new int[2] { 360, 440 };
            ladder_top[3] = new int[2] { 120, 440 };
            ladder_top[4] = new int[2] { 280, 120 };
            ladder_top[5] = new int[2] { 520, 280 };
            ladder_top[6] = new int[2] { 760, 40 };
            ladder_top[7] = new int[2] { 280, 40 };

            for (int i = 0; i < 8; i++)
            {
                if(this._CoorX == ladder_bot[i][0] && this._CoorY == ladder_bot[i][1])
                {
                    this._CoorX = ladder_top[i][0];
                    this._CoorY = ladder_top[i][1];
                }
            }
        }

        public void SnakeBite()
        {
            int[][] snake_head = new int[8][];
            int[][] snake_tail = new int[8][];

            snake_head[0] = new int[2] { 200, 40 };
            snake_head[1] = new int[2] { 440, 40 };
            snake_head[2] = new int[2] { 680, 120 };
            snake_head[3] = new int[2] { 520, 200 };
            snake_head[4] = new int[2] { 440, 280 };
            snake_head[5] = new int[2] { 120, 280 };
            snake_head[6] = new int[2] { 680, 360 };
            snake_head[7] = new int[2] { 440, 600 };

            snake_tail[0] = new int[2] { 120, 200 };
            snake_tail[1] = new int[2] { 440, 200 };
            snake_tail[2] = new int[2] { 680, 280 };
            snake_tail[3] = new int[2] { 280, 680 };
            snake_tail[4] = new int[2] { 120, 360 };
            snake_tail[5] = new int[2] { 120, 680 };
            snake_tail[6] = new int[2] { 280, 680 };
            snake_tail[7] = new int[2] { 280, 680 };

            for (int i = 0; i < 8; i++)
            {
                if (this._CoorX == snake_head[i][0] && this._CoorY == snake_head[i][1])
                {
                    this._CoorX = snake_tail[i][0];
                    this._CoorY = snake_tail[i][1];
                }
            }
        }
    }
}
