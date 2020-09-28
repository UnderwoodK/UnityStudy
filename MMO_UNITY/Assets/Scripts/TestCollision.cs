using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{

    // 1. 나에게 Rigidbody 가 있어야 한다. (IsKinematics : off)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"콜리젼 신난당 : {collision.gameObject.name}");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"트리거 신난당 : {other.name}");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
