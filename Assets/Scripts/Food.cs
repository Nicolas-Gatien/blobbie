using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int scoreValue;

    public GameObject deathEffect;

    public GameObject food;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("PickUp");

            ScoreManager.score += scoreValue;
            if (deathEffect != null)
            {
                Instantiate(deathEffect, transform.position, transform.rotation);
            }
            Destroy(gameObject);

        }
        if (other.CompareTag("Enemy"))
        {
            FindObjectOfType<AudioManager>().Play("Death");
            if (deathEffect != null)
            {
                Instantiate(deathEffect, transform.position, transform.rotation);
                Instantiate(food, transform.position, transform.rotation);
                Instantiate(food, transform.position, transform.rotation);
                Instantiate(food, transform.position, transform.rotation);
            }
            if (food != null)
            {
                Instantiate(food, transform.position, transform.rotation);
                Instantiate(food, transform.position, transform.rotation);
                Instantiate(food, transform.position, transform.rotation);
            }
            Destroy(other.gameObject);

        }
    }
}
