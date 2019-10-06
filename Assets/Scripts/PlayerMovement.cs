using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rb;

    Vector2 mousePos;
    public Camera cam;

    public Animator anim;

    void Start()
    {
        ScoreManager.score = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Moving", true);
        }
        else
        {
            anim.SetBool("Moving", false);

        }
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }

    void FixedUpdate()
    {



        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;




        var mousePos2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var mouseDir = mousePos2 - gameObject.transform.position;
        mouseDir.z = 0.0f;
        mouseDir = mouseDir.normalized;

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(mouseDir * speed);
        }

    }
}