using System.Collections;
using System.Collections.Generic;
using Entity;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Instance.hero.Run();
        GameManager.Instance.hero.Jump();
        GameManager.Instance.hero.Attack();
    }
}
