using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public Transform[] point;
    private int currentPoint;
    public float moveSpeed = 10.0f;
    public float steerSpeed = 30.0f;
    public enum Mode
    {
        Automatic,
        Manual
    }
    public Mode mode;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bat dau choi!");
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == Mode.Automatic)
        {
            if (Vector3.Distance(transform.position, point[currentPoint].position) < speed)
            {
                currentPoint++;
            }
            if (currentPoint >= point.Length)
            {
                currentPoint = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position, point[currentPoint].position, speed * Time.deltaTime);
            transform.LookAt(point[currentPoint].position);
        }
        else if (mode == Mode.Manual)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            transform.Translate(0, 0, v * moveSpeed * Time.deltaTime);
            transform.Rotate(0, h * steerSpeed * Time.deltaTime, 0);
        }
    }
}
