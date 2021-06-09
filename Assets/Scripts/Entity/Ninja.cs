using UnityEngine;

namespace Entity
{
    public class Ninja: Hero
    {
        public Ninja(GameObject gameObject): base(gameObject)
        {
            speed = 20;
            jumpForce = 500;
        }

        public override void Attack()
        {
            base.Attack();

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                GameManager.Instance.instanciateProjectil(gameObject.transform.position, spriteRenderer.flipX);
            }
        }
    }
}