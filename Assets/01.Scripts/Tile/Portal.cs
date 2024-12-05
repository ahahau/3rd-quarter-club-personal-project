using System;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private GameObject nextPortalPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        PlayerMove playerMove = player.GetComponent<PlayerMove>();
        
    }
}
