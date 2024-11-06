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
        public int currentHealth;
        //Functions

        public void Setup()
        {
            colour = color.Red;
            position = new Vector2(50, 600);
            radius = 40;
            velocity = new Vector2(0);
            speed = 10;
            currentHealth = 10;
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

            KeepInWindowBounds();
        }

        void KeepInWindowBounds()
        {
        //Stopping player from going above top of screen
          if (position.Y < 0 + radius)
            {
                position.Y = 0 + radius;

            }
          // Stopping player from going to bottom of screen
          if (position.Y >  800 - radius)
            {
                position.Y = 800 - radius;
            }
          //stopping player from going to left side of  the screen
          if (position.X < 0 + radius)
            {
                position.X = 0 + radius;
            }
            //stopping player from going to right side of  the screen
            if (position.X > 600 - radius)
            {
                position.X = 600 - radius;
            }
        }

        public void DrawPlayer()
        {
            Draw.FillColor = colour;
            Draw.Circle(position, radius);


        }

        public void ReduceHealth()
        {
            currentHealth -= 1;

        }
}

}

