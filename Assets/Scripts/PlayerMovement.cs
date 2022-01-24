using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;

    private Vector3 _direction;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        transform.LookAt(_direction + transform.position);



    }

    void FixedUpdate()
    {
        transform.position = transform.position + _direction * Time.fixedDeltaTime * Speed;
    }
}
