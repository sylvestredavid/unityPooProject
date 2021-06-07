using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalInput, 0, 0) * Time.deltaTime * speed;
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
}
