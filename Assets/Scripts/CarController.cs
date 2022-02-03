using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    float forwardAccel = 8f, reverseAccel = 4f, maxSpeed = 50f, turnStrength = 180;

    void Start()
    {
        rb.transform.parent = null;
    }
    private void Update()
    {
        transform.position = rb.position;
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * forwardAccel * 100f);
    }
}
