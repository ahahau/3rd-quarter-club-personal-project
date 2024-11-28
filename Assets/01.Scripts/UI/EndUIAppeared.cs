using System.Collections;
using DG.Tweening;
using UnityEngine;

public class EndUIAppeared : MonoBehaviour
{
    public RectTransform uiElement; 
    private float duration = 1f;
    private float startOffset = 500f;
    void OnEnable()
    {
        Vector3 startPos = uiElement.anchoredPosition;
        startPos.y += startOffset;
        uiElement.anchoredPosition = startPos;
        uiElement.DOAnchorPosY(startPos.y - startOffset, duration)
            .SetEase(Ease.OutBounce);
    }
}
