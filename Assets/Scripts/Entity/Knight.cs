using UnityEngine;

namespace Entity
{
    public class Knight: Hero
    {
        public Knight(GameObject gameObject): base(gameObject)
        {
            speed = 15;
            jumpForce = 400;
        }
    }
}