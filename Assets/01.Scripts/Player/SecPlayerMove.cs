using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SecPlayerMove : PlayerState
{
    private float _moveDelay = 0.25f; 
    private bool _isMove;
    [SerializeField] private List<Transform> tile = new List<Transform>();
    [SerializeField]private int _curPos = 12;
    private Vector3 _startPos;

    private void Start()
    {
        _startPos = transform.position;
    }

    private void Update()
    {
        if (GameManager.Instance.firArrive && GameManager.Instance.secArrive)
        {
            this.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.W)) VNextPos(1); 
        if (Input.GetKeyDown(KeyCode.S)) VNextPos(-1); 
        if (Input.GetKeyDown(KeyCode.A)) HNextPos(1); 
        if (Input.GetKeyDown(KeyCode.D)) HNextPos(-1); 
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

    private void Move(int curPos)
    {
        if (_isMove) return; 
        _isMove = true;

        Vector3 targetPosition = new Vector3(tile[curPos].position.x, tile[curPos].position.y, transform.position.z);
        transform.DOMove(targetPosition, _moveDelay)
            .SetEase(Ease.OutCubic);
        _isMove = false;
        GameManager.Instance.moveCnt++;
    }
}
