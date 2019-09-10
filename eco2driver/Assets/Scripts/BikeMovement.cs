using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeMovement : MonoBehaviour
{
    public float speed = 100.0f;
    public float rotationSpeed = 100.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 v = gameObject.transform.up;
            rb.AddForce(v * Time.deltaTime * speed, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 v = gameObject.transform.up;
            rb.AddForce(-v * Time.deltaTime * speed, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles += new Vector3(0, 0, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles -= new Vector3(0, 0, rotationSpeed * Time.deltaTime);
        }
        rb.velocity *= 0.9f;
    }
}
