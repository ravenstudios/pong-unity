using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player1 : MonoBehaviour
{

    [SerializeField]
    float _speed = 5;

    [SerializeField]
    Rigidbody2D rb;

    PlayerContols _playerContols;

    private void Awake()
    {
        _playerContols = new PlayerContols();
    }

    private void OnEnable()
    {
        _playerContols.Enable();
    }

    private void OnDisable()
    {
        _playerContols.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        float y = _playerContols.Gameplay.Movment.ReadValue<float>();
        rb.velocity = new Vector2(0, y * Time.deltaTime * _speed);
    }

}
