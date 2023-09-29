using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Player _player;
    void Update()
    {
        transform.position = _player.transform.position;
    }
}
