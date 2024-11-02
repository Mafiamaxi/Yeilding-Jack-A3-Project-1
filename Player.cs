using System;
using System.Numerics;

namespace Game10003
{
    class Player
    {
        public Vector2 position = new Vector2();
        Vector2 velocity = new Vector2();
        public float radius;
        color colour;
        float speed;
        int health;
        //Functions

        public void Setup()
        {
            colour = color.Red;
            position = new Vector2(400, 600);
            radius = 100;
            velocity = new Vector2(0);
            speed = 10;
        }

        public void MovePlayer()
        {
            //Getting user input (WASD)
            velocity.X = 0; 
            velocity.Y = 0;
            if (Input.IsKeyboardKeyDown(KeyboardInput.S))
            {
                velocity.Y = +1;
            }

            else if (Input.IsKeyboardKeyDown(KeyboardInput.W))
            {
                velocity.Y = -1;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.D))
            {
                velocity.X = +1;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.A))
            {
                velocity.X = -1;
            }
            position += velocity * speed;
        }

        public void KeepInWindowBounds()
        {

        }

        public void DrawPlayer()
        {
            Draw.FillColor = colour;
            Draw.Circle(position, radius);


        }

        public void ReduceHealth()
        {
            health -= 1;

        }
}

}

