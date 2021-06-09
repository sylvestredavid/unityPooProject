using System.Collections;
using System.Collections.Generic;
using Entity;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void SelectHero(Button btn)
    {
        gameObject.SetActive(false);
        GameManager.Instance.setHero(btn.name);
    }
}
