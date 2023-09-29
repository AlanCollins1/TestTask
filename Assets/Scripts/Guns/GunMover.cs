using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMover : MonoBehaviour {
    [SerializeField] private Joystick _joystick;
    public float Speed;

    private void FixedUpdate() {
        //Debug.Log(Mathf.Atan2(_joystick.Value.y,_joystick.Value.x) * Mathf.Rad2Deg);
        if (_joystick.IsPressed == true) {
            transform.localRotation = Quaternion.Euler(0, 0, Mathf.Atan2(_joystick.Value.y, Mathf.Abs(_joystick.Value.x)) * Mathf.Rad2Deg + 90);
        }
    }
}
