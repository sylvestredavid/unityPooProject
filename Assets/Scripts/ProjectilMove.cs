using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilMove : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float speed;
    [SerializeField] private bool isLeft;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        StartCoroutine("destroyProjectil");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(isLeft ? -1 : 1, 0, 0) * Time.deltaTime * speed;
    }

    IEnumerator destroyProjectil()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
