using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet : MonoBehaviour
{
    public string magnetTag = "Magnet";

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(magnetTag))
        {
            // nối hai đối tượng với nhau bằng cách thêm các rẽ nhánh vào đối tượng và đối tượng muốn nối với
            Joint joint = gameObject.AddComponent<FixedJoint>();
            joint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();
        }
    }
}
