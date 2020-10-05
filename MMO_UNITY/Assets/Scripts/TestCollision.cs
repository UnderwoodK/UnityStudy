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
        

        Vector3 look = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position + Vector3.up, look * 10, Color.red);

        // RaycastHit hit;
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position + Vector3.up, look, 10);
        // Physics.RaycastAll(transform.position + Vector3.up, look, out hit, 10);
        //if (Physics.Raycast(transform.position + Vector3.up, look, out hit, 10))
        //{
        //    Debug.Log($"Physics.Raycast + {hit.collider.gameObject.name}");
        // }// -> 만났는지 안만났는지 true / false 반환

        foreach(RaycastHit hit in hits)
        {
            Debug.Log($"Raycast : {hit.collider.gameObject.name}");
        }
     

    }
}
