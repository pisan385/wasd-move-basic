using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting triangle: " + gameObject.name);
    }

    public float speed; // set to 8 from Unity visual interface

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
