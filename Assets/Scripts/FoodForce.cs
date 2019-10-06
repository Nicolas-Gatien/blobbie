using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodForce : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        float startRot = Random.Range(0, 360);
        transform.localRotation = Quaternion.Euler(0, 0, startRot);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * force);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
