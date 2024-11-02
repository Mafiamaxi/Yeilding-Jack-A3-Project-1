﻿// Include code libraries you need below (use the namespace).
using System.Numerics;


namespace Game10003
{
    class Enemy
    {
        //Variables:
        Vector2 position = new Vector2();
        Vector2 velocity = new Vector2();
        color colour;
        int speed;
        public string nameToEnemy = "Destroyer";

        public int healthToEnemy = 10;
        public int defenseToEnemy = 70;

        //Runs once when the application is started
        public void Setup()
        {

             nameToEnemy = "Goomba";
            healthToEnemy = 110;
            defenseToEnemy = 100;
            ResetEnemy();
            colour = color.Blue;

            velocity.X = -1;
            velocity.Y = 0;
        }

        private void ResetEnemy()
        {
            position.Y = Random.Integer(100, 700);
            position.X = 605;
            speed = Random.Integer(15, 20);

        }
        
        public void DrawEnemy()
        {
            Draw.FillColor = colour;
            Draw.Circle(position.X, position.Y, 30);
           
        }

        public void MoveEnemy()
        {
            position += velocity * speed;
            if (position.X < 0)
            {
                ResetEnemy();
            }
        }

    }
}