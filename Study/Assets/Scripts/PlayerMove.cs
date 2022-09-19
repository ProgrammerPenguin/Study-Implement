using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed;

    private float _inputX = 0f;
    private float _inputY = 0f;

    private ClosePlayer _closePlayer;

    private void Start()
    {
        _closePlayer = GetComponent<ClosePlayer>();
    }

    void Update()
    {
        _inputX = Input.GetAxis("Horizontal");
        _inputY = Input.GetAxis("Vertical");
        Move();
        Invoke("ClosePlayer", 3f);
    }

    private void Move()
    {
        Vector3 MovePosition = new Vector3(_inputX, 0f, _inputY).normalized;
        transform.position += MoveSpeed * Time.deltaTime * MovePosition;
    }

    private void ClosePlayer()
    {
        _closePlayer.enabled = true;
    }
}