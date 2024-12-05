using System;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using NUnit.Framework;
using UnityEngine.UI;

public class PlayerMove : PlayerState
{
    private float _moveDelay = 0.25f; 
    private bool _isMove;
    [SerializeField] public List<Transform> tile = new List<Transform>();
    [SerializeField]public int _curPos = 12;
    private Vector3 _startPos;
    [SerializeField]public List<int> playerType = new List<int>();
    private void Start()
    {
        _startPos = transform.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) VNextPos(playerType[0]); 
        if (Input.GetKeyDown(KeyCode.S)) VNextPos(playerType[1]); 
        if (Input.GetKeyDown(KeyCode.A)) HNextPos(playerType[0]); 
        if (Input.GetKeyDown(KeyCode.D)) HNextPos(playerType[1]); 
        if (GameManager.Instance.firArrive && GameManager.Instance.secArrive)
        {
            this.enabled = false;
        }
    }

    private void HNextPos(int nextDir)
    {
        if ((_curPos % 5 == 0 && nextDir < 0) || ((_curPos + 1) % 5 == 0 && nextDir > 0))
            return;

        int newPos = _curPos + nextDir;

        if (newPos >= 0 && newPos < tile.Count)
        {
            _curPos = newPos;
            Move(_curPos);
        }
    }

    private void VNextPos(int nextDir)
    {
        nextDir *= 5;
        int newPos = _curPos + nextDir;

        if (newPos >= 0 && newPos < tile.Count)
        {
            _curPos = newPos;
            Move(_curPos);
        }
    }

    public void Move(int curPos)
    {
        if (_isMove) return; 
        _isMove = true;

        Vector3 targetPosition = new Vector3(tile[curPos].position.x, tile[curPos].position.y, transform.position.z);
        transform.DOMove(targetPosition, _moveDelay)
            .SetEase(Ease.OutCubic);
        _isMove = false; 
    }
}
