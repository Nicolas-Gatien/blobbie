using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    public float waitBeforeFirstSpawn = 0;
    public float waitTime = 7;
    public GameObject food;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(WaitBeforeFirstSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator WaitBeforeFirstSpawn ()
    {
        yield return new WaitForSeconds(waitBeforeFirstSpawn);
        StartCoroutine(SpawnFood());
        Instantiate(food, transform.position, Quaternion.identity);


    }



    IEnumerator SpawnFood()
    {
        yield return new WaitForSeconds(waitTime);
        Instantiate(food, transform.position, Quaternion.identity);
        StartCoroutine(SpawnFood());
    }
}
