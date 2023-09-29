using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMove : MonoBehaviour {
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Joystick _joystick;
    private Vector2 _moveInput;
    //[SerializeField] private Animation _animation;

    private void Update() {
        _moveInput = _joystick.Value;
    }
    private void FixedUpdate() {
        _rigidbody.velocity = new Vector2(_moveInput.x * _speed, _moveInput.y * _speed);
        if (_joystick.IsPressed == true) {
            if (_moveInput.x < 0) {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }
}
