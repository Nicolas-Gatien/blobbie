using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 movement;
    public string levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }


    void MoveCharacter()
    {
        rb.AddForce(movement * speed);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("Death");

            FindObjectOfType<SceneTransitions>().LoadScene("Stage2");
        }
    }
}
