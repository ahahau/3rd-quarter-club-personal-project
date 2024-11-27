using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    public bool firArrive;
    public bool secArrive;
    public int moveCnt;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
