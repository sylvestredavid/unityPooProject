using System;
using System.Collections.Generic;
using Entity;
using UnityEngine;

public delegate void HeroInstantiated();
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static event HeroInstantiated onInstantiate;
    public Hero hero;
    [SerializeField] private List<GameObject> heroPrefabs;
    [SerializeField] private GameObject rightProjectilPrefab;
    [SerializeField] private GameObject leftProjectilPrefab;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void setHero(string heroType)
    {
        Vector3 pos = new Vector3(-71.6f, 3.71f, -0.63f);
        switch (heroType)
        {
            case "Dino":
                GameObject dino = Instantiate(heroPrefabs[0], pos,
                    heroPrefabs[0].transform.rotation);
                hero = new Dino(dino);
                break;
            case "Knight":
                GameObject knight = Instantiate(heroPrefabs[1], pos,
                    heroPrefabs[1].transform.rotation);
                hero = new Knight(knight);
                break;
            case "Ninja":
                GameObject ninja = Instantiate(heroPrefabs[2], pos,
                    heroPrefabs[2].transform.rotation);
                hero = new Ninja(ninja);
                break;
            case "Zombie":
                GameObject zombie = Instantiate(heroPrefabs[3], pos,
                    heroPrefabs[3].transform.rotation);
                hero = new Zombie(zombie);
                break;
            default:
                Debug.LogError("ce hero n'existe pas");
                break;
        }

        if (onInstantiate != null)
        {
            onInstantiate();
        }
    }

    public void instanciateProjectil(Vector3 pos, bool isFlip)
    {
        if(!isFlip)
        {
            Instantiate(rightProjectilPrefab, pos, rightProjectilPrefab.transform.rotation);
        }
        else
        {
            Instantiate(leftProjectilPrefab, pos, leftProjectilPrefab.transform.rotation);
        }
    } 
}