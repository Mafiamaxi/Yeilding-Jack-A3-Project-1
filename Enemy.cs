﻿// Include code libraries you need below (use the namespace).
using System.Numerics;


namespace Game10003
{
    class Enemy
    {
        //Variables:
        public Vector2 position = new Vector2();
        Vector2 velocity = new Vector2();
        color colour;
        GameUI gameui;
        int speed;
        public float radius;

        //Constructor
        public Enemy(GameUI gameuiRef)
        {
            gameui = gameuiRef;
        }

        //Runs once when the application is started
        public void Setup()
        {
            ResetEnemy();
            colour = color.Blue;
            radius = 30;

            velocity.X = -1;
            velocity.Y = 0;
        }

        public void ResetEnemy()
        {
            position.Y = Random.Integer(100, 700);
            position.X = 605;
            speed = Random.Integer(5, 15);
        }
        
        public void DrawEnemy()
        {
            Draw.FillColor = colour;
            Draw.Circle(position.X, position.Y, radius);
        }

        public void MoveEnemy()
        {
            position += velocity * speed;
            
            if (position.X < 0)
            {
                ResetEnemy();
                gameui.IncreaseScore();
            }
        }
    }
}