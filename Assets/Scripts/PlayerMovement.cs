using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody carRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        this.carRigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.A))
        {
            carRigidbody.AddRelativeTorque(new Vector3(0,-10f,0), ForceMode.Acceleration);
        }   
        if(Input.GetKey(KeyCode.Space))
        {
            carRigidbody.AddRelativeForce(new Vector3(0,0,10f), ForceMode.Acceleration);
        }   
        if(Input.GetKey(KeyCode.D))
        {
            carRigidbody.AddRelativeTorque(new Vector3(0,10f,0), ForceMode.Acceleration);
        }   
    }
}
