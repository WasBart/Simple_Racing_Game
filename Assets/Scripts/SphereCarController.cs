using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, Input.GetAxis("Vertical") * 5.0f), ForceMode.Acceleration);
        GetComponent<Rigidbody>().AddTorque(0, Input.GetAxis("Horizontal"), 0);
    }
}
