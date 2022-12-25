using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour {

    public Transform target;
    int distance = -40;
    float lift = 0f;

    void Update()
    {
        transform.position = new Vector3(0, lift, distance) + target.position;
        transform.LookAt(target);
    }


}

