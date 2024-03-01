using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
     private void OnCollisionEnter(Collision collision)
     {
         Debug.Log("Bat dau va cham");
     }
     private void OnCollisionStay(Collision collision)
     {
         Debug.Log("Va cham va giu nguyen");
     }
     private void OnCollisionExit(Collision collision)
     {
         Debug.Log("Ket thuc va cham");
     }
     */
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Bat dau va cham");
        }
        
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Dang va cham");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Va cham xong");
    }
}
