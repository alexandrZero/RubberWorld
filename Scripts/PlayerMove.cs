using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rigidbody;
    private bool _canJump;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, CameraWatch.xRot, 0);
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddRelativeForce(new Vector3(0, 0, _speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddRelativeForce(new Vector3(0, 0, -_speed));
        }
        if (Input.GetKey(KeyCode.D))
        {
           _rigidbody.AddRelativeForce(new Vector3(_speed, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
           _rigidbody.AddRelativeForce(new Vector3(-_speed, 0));
        }
        if (Input.GetKey(KeyCode.Space) && _canJump)
        {
            _rigidbody.AddRelativeForce(new Vector3(0, _speed * 1.5f));
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject)
        {
            _canJump = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject)
        {
            _canJump = false;
        }
    }
}
