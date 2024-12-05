using System;
using UnityEngine;

public class Terminal : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("FirPlayer"))
        {
            GameManager.Instance.firArrive = true;
            print("FirPlayerEnter");
        }

        if (collision.CompareTag("SecPlayer"))
        {
            GameManager.Instance.secArrive = true;
            print("SecPlayerEnter");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("FirPlayer"))
        {
            GameManager.Instance.firArrive = false;
            print("FirPlayerExit");
        }

        if (collision.CompareTag("SecPlayer"))
        {
            GameManager.Instance.secArrive = false;
            print("SecPlayerExit");
        }
    }
}
