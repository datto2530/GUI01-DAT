using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputGameManager : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float steerSpeed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(0, 0, v * moveSpeed * Time.deltaTime);
        transform.Rotate(0, h * steerSpeed * Time.deltaTime, 0);
    }
}
