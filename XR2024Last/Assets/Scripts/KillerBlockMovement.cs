using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerBlockMovement : MonoBehaviour
{
    public float movementForce = 10f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

    }

    void FixedUpdate()
    { 

        rb.AddForce(new Vector3(Random.Range(-1f, 1f), 0f, Random.Range (-1f, 1f)) * movementForce, ForceMode.Impulse);

    }
}
    