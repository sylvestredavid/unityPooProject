using System;
using UnityEngine;

namespace Entity
{
    public class Hero
    {
        protected GameObject gameObject;
        protected Rigidbody2D rb;
        protected Animator anim;
        protected SpriteRenderer spriteRenderer;
        protected float speed;
        protected float jumpForce;
        private int lives = 3;
        public int Lives
        {
            get { return lives; }
            set
            {
                if (value >= 0)
                {
                    lives = value;
                }
                else
                {
                    Debug.LogError("la vie ne peut pas etres inférieur à 0");
                }
            }
        }

        public Hero(GameObject gameObject)
        {
            this.gameObject = gameObject;
            rb = gameObject.GetComponent<Rigidbody2D>();
            anim = gameObject.GetComponent<Animator>();
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        }

        public virtual void Run()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            gameObject.transform.position += new Vector3(horizontalInput, 0, 0) * Time.deltaTime * speed;
            anim.SetBool("run_b",horizontalInput != 0);

            if (horizontalInput < 0)
            {
                spriteRenderer.flipX = true;
            }
            else if(horizontalInput > 0)
            {
                spriteRenderer.flipX = false;
            }
        }

        public virtual void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpForce);
                anim.SetTrigger("jump_t");
            }
        }

        public virtual void Attack()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                anim.SetTrigger("attack_t");
            }
        }
    }
}