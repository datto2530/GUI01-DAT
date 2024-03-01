using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float health;
    private float fuel;
    private float capacity = 100f;
    private int lap = 0;
    // Start is called before the first frame update
    void Start()
    {
        fuel = capacity;
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
            health -= 5;
            Debug.Log(health);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "BarrelRed")
        {
            fuel += 25;
            if (fuel > 100)
            {
                fuel = 100;
            }
            Debug.Log(fuel);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "BarrelBlue")
        {
            fuel += 10;
            if (fuel > 100)
            {
                fuel = 100;
            }
            Debug.Log(fuel);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Box")
        {
            health += 30;
            if (health > 100)
            {
                health = 100;
            }
            Debug.Log(health);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "BoxFull")
        {
            health = 100;
            Debug.Log(health);
            Destroy(collision.gameObject);
        }
        if (health<=0)
        {
            SceneManager.LoadScene("Lesson6");
        }
        if (collision.gameObject.name == "Finish")
        {
            lap += 1;
            Debug.Log(lap);
            
        }
    }
}
