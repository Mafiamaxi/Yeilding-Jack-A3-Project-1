using System.Numerics;

namespace Game10003
{
    class Collision
    
    {
        Player player;
        Enemy[] enemies;

        //Constructor
        Collision(Player ply, Enemy[] enem)
        {
            player = ply;
            enemies = enem;
        }

        void CheckForCollisions()
        {
           //We are looping through all the enemies
            for (int i = 0; i < enemies.Length; i++)
            {
                //Check distance between player and enemies

                float distance = Vector2.Distance(player.position, enemies[i].position);
                float playerRadius = player.radius;
                float enemyRadius = enemies[i].radius;



            }


        }
    }

 
}
