// Include code libraries you need below (use the namespace).
using System;
using System.Data;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Vector2 position = new Vector2();
        Vector2 velocity = new Vector2();
        float radius;
        color color;
        Enemy[] ENEMY = new Enemy[7];
        Player player;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Caterpillar 1.0");
            Window.SetSize(600, 800);


            //Set up enemy
            position = Window.Size / 3;
            velocity = Random.Direction() * 50;
            radius = 35;
            color = Random.Color();

            for (int i = 0; i < ENEMY.Length; i++)
            {
                ENEMY[i] = new Enemy();
                ENEMY[i].Setup();
                ENEMY[i].DrawEnemy();


            }
            //Set up Player
            player = new Player();

           player.Setup();


        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(color.White);

            for (int i = 0; i < ENEMY.Length; i++)
            {
                ENEMY[i].DrawEnemy();
                ENEMY[i].MoveEnemy();
            }

            player.MovePlayer();
            player.DrawPlayer();
            //Move Enemy
            //position += velocity * Time.DeltaTime; 
          



            //Keep Enemy inside screen
            
            bool isTouchingTop = position.X <= 0 + radius;
            bool isTouchingBottom = position.Y >= Window.Height - radius;
            bool isTouchingLeft = position.X <= 0 + radius;
            bool isTouchingRight = position.X >= Window.Width - radius;


            if (isTouchingTop || isTouchingBottom)
            {
                velocity.Y = -velocity.Y;
            }

            if (isTouchingLeft || isTouchingRight)
            {
                velocity.X = -velocity.X;
            }

            if (isTouchingTop || isTouchingBottom || isTouchingLeft || isTouchingRight)
            {
                color = Random.Color();


            }

        }

    }
}
