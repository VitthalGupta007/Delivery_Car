using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingtoFollow;
    //this thing position (camrea) should be the same as the car's position

    void LateUpdate()
    {
        transform.position = thingtoFollow.transform.position + new Vector3 (0, 0, -10) ;
    }
}
