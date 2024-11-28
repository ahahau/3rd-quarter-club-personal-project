using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clear : MonoBehaviour
{
    [SerializeField]private List<GameObject> basicUi = new List<GameObject>();
    [SerializeField]private GameObject clearUi;
    [SerializeField] private TextMeshProUGUI stageName;
    private void Update()
    {
        if (GameManager.Instance.firArrive && GameManager.Instance.secArrive)
        {
            foreach (var ui in basicUi)
            {
                ui.SetActive(false);
            }
            stageName.SetText("");
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.15f);
        clearUi.SetActive(true);
    }
}
