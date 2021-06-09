using UnityEngine;

namespace Entity
{
    public class Dino: Hero
    {
        public Dino(GameObject gameObject): base(gameObject)
        {
            speed = 10;
            jumpForce = 250;
        }
    }
}