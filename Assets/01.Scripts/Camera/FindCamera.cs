using System;
using UnityEngine;

public class FindCamera : MonoBehaviour
{
    private Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        if(canvas.worldCamera == null) canvas.worldCamera = Camera.main;
            
    }
}
