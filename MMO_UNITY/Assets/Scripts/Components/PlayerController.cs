using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 6f;

    void Start()
    {

        // 구독신청
        Manager.Input.KeyAction -= OnKeyboard;
        Manager.Input.KeyAction += OnKeyboard;
        // Manager mg = Manager.Instance;
    }

    // GameObject (Player)
    // Transform
    // PlayerController

    float _yAngle;
    void Update()
    {


    }

    void OnKeyboard()
    {
        // transform.Rotate(new Vector3(0f, Time.deltaTime * 1f, 0f));
        // _yAngle += Time.deltaTime * 100;

        // transform.Rotate(new Vector3(0f, -_yAngle, 0f));

        // transform.rotation = Quaternion.Euler(new Vector3(0f, _yAngle, 0f));


        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.1f);
            transform.position += Vector3.forward * Time.deltaTime * speed;

            //transform.rotation = Quaternion.Euler(new Vector3(0f, _yAngle, 0f));
            // transform.rotation = Quaternion.LookRotation(Vector3.forward);
            // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.1f);
            // transform.position += Vector3.forward * Time.deltaTime * speed;
            // transform.Translate(Vector3.forward * Time.deltaTime * speed);
            // transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
            // transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime * speed;
            // transform.position += transform.TransformDirection(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.1f);
            transform.position += Vector3.back * Time.deltaTime * speed;

            // transform.rotation = Quaternion.Euler(new Vector3(0f, -_yAngle, 0f));
            // transform.rotation = Quaternion.LookRotation(Vector3.back);
            // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.1f);
            // transform.position += Vector3.back * Time.deltaTime * speed;
            // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.1f);
            transform.position += Vector3.left * Time.deltaTime * speed;

            // transform.rotation = Quaternion.LookRotation(Vector3.left);
            // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.1f);
            // transform.position += Vector3.left * Time.deltaTime * speed;
            // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.1f);
            transform.position += Vector3.right * Time.deltaTime * speed;

            // transform.rotation = Quaternion.LookRotation(Vector3.right);
            // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.1f);
            // transform.position += Vector3.right * Time.deltaTime * speed;
            // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }

}
