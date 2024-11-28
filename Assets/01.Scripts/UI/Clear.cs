using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    [SerializeField]private List<GameObject> basicUi = new List<GameObject>();
    [SerializeField]private GameObject clearUi;
    private void Update()
    {
        if (GameManager.Instance.firArrive && GameManager.Instance.secArrive)
        {
            foreach (var ui in basicUi)
            {
                ui.SetActive(false);
                StartCoroutine(Wait());
            }
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.15f);
        clearUi.SetActive(true);
    }
}
