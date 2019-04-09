using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Captain.Command
{
    public class MoveCharacterRight : ScriptableObject, ICaptainCommand
    {
        private float Speed = 5.0f;

        public void Execute(GameObject gameObject)
        {
            //Get the rigid body
            var rigidBody = gameObject.GetComponent<Rigidbody2D>();

            //Check if the rigid body exists
            if (rigidBody != null)
            {
                //Set velocity to be (speed, current y velocity)
                rigidBody.velocity = new Vector2(this.Speed, rigidBody.velocity.y);

                //Do not flip
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
        }
    }
}
