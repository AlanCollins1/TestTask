using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class SetDistance : MonoBehaviour {
    public int Distance;

    public int ObjectDistance() {
        return Distance;
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected() {
        Handles.color = Color.gray;
        Handles.DrawWireDisc(transform.position, Vector3.forward, Distance);
    }
#endif
}
