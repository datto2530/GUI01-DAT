using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementRb : MonoBehaviour
{

    private Rigidbody rb;
    public float speedPosition = 20.0f;
    public float speedRotaion = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        // rb.velocity = transform.position + new Vector3(0,0,v * Time.deltaTime * speedPosition);
        rb.MovePosition(rb.position + new Vector3 (0,0, v * speedPosition * Time.deltaTime));
        rb.MoveRotation(transform.rotation * Quaternion.Euler(new Vector3(0, h * Time.deltaTime * speedRotaion, 0)));
    }
}
