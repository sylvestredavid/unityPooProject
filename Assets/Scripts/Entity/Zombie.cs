using UnityEngine;

namespace Entity
{
    public class Zombie: Hero
    {
        public Zombie(GameObject gameObject): base(gameObject)
        {
            speed = 7;
            jumpForce = 0;
        }
    }
}