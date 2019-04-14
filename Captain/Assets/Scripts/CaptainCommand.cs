using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Captain.Command
{
    public class CaptainCommand : ScriptableObject, ICaptainCommand
    {
        public void Execute(GameObject gameObject)
        {
            //Jump
            var rigidBody = gameObject.GetComponent<Rigidbody2D>();

            rigidBody.velocity = new Vector2(0, 10);
        }
    }
}