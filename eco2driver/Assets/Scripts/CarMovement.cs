using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 v = gameObject.transform.up;
            rb.AddForce(v * Time.deltaTime * speed, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 zVector = new Vector3(0.0f, 0.0f, 1.0f);
            rb.AddTorque(zVector * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 zVector = new Vector3(0.0f, 0.0f, -1.0f);
            rb.AddTorque(zVector * rotationSpeed * Time.deltaTime);
        }
        rb.velocity *= 0.9f;
    }
}
