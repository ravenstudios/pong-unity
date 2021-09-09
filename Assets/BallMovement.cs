using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    float _verticalSpeed = 5f;
    [SerializeField]
    float _horizontalSpeed = 5f;

    [SerializeField]
    Rigidbody2D rb;

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity =new Vector2(_verticalSpeed, _horizontalSpeed);
        //float rand = Random.Range(0, 2);
        //if (rand < 1)
        //{
            
        //}
        //else
        //{
        //    rb.AddForce(new Vector2(-20, _verticalSpeed));
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
