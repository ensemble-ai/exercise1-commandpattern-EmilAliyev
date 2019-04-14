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
            //Jump
            var rigidBody = gameObject.GetComponent<Rigidbody2D>();

            rigidBody.velocity = new Vector2(0, 10);
        }
    }
}