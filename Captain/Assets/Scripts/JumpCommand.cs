using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Captain.Command
{
    //This command causes the captain to jump. 

    public class JumpCommand : ScriptableObject, ICaptainCommand
    {
        public void Execute(GameObject gameObject)
        {
            //Get rigid body
            var rigidBody = gameObject.GetComponent<Rigidbody2D>();

            //Check y velocity to see if already in air. If not, jump
            float yvel = rigidBody.velocity[1];

            if (yvel == 0)
            {
                rigidBody.velocity = new Vector2(0, 10);
            }
        }
    }
}