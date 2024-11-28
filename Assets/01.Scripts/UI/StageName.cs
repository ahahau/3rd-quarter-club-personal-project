using System;
using TMPro;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class StageName : MonoBehaviour
{
    [SerializeField]private string stageName;
    private TextMeshProUGUI myTMP;
    private void OnEnable()
    {
        myTMP = GetComponent<TextMeshProUGUI>();
        myTMP.text = stageName;
    }
}
