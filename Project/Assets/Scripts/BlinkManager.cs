using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlinkManager : MonoBehaviour
{
    public Slider blinkSlider;

    public SpriteRenderer spriteRend;

    public string levelToLoad;

    public Color color;

    public bool HaveLoaded;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void Update()
    {

        

            if (blinkSlider.value < 6)
        {
            spriteRend.color = color;
            if (blinkSlider.value == 0)
            {
                Debug.Log("Loading...");
                if (HaveLoaded == false)
                {
                    FindObjectOfType<AudioManager>().Play("Death");
                    HaveLoaded = true;

                }

                FindObjectOfType<SceneTransitions>().LoadScene("Stage2");
            }
        }
        else
        {
            spriteRend.color = Color.white;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (blinkSlider.gameObject.activeSelf == true)
        {
            blinkSlider.value -= Time.deltaTime;

        }
    }
}
