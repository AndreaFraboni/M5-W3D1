using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rb;

    private Vector3 _direction;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");

       // if (_direction.magnitude > 0.01f) _direction.Normalize();
    }

    private void FixedUpdate()
    {
        _rb.velocity = _direction * _speed * Time.deltaTime;
    }


}
