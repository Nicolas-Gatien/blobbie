using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    [Header("Moving Spawnpoints")]

    [Space]

    public GameObject spawnpoint1;
    public Vector3 spawnpoint1Offset;
    public GameObject spawnpoint2;
    public Vector3 spawnpoint2Offset;
    public GameObject spawnpoint3;
    public Vector3 spawnpoint3Offset;
    public GameObject spawnpoint4;
    public Vector3 spawnpoint4Offset;
    public GameObject spawnpoint5;
    public Vector3 spawnpoint5Offset;
    public GameObject spawnpoint6;
    public Vector3 spawnpoint6Offset;
    public GameObject spawnpoint7;
    public Vector3 spawnpoint7Offset;
    public GameObject spawnpoint8;
    public Vector3 spawnpoint8Offset;

    [Space]
    [Space]
    [Space]
    [Space]
    [Space]
    public GameObject player;
    public GameObject myCamera;


    public int foodBeforeNextStage;

    [Header("Eyesight Upgrade")]
    [Space]

    public int maxEyesight;
    public int eyesightsBought;


    public int foodBeforeNextEyesight;
    public Button eyeSightButton;

    public GameObject eye1;
    public GameObject eye2;
    public GameObject eye3;
    public GameObject eye4;
    public GameObject eye5;

    public Animator eye1Anim;
    public Animator eye2Anim;
    public Animator eye3Anim;
    public Animator eye4Anim;
    public Animator eye5Anim;
    public Animator eye6Anim;
    public Animator eye7Anim;
    public Animator eye8Anim;
    public Animator eye9Anim;
    public Animator eye10Anim;
    public Animator eye11Anim;
    public Animator eye12Anim;
    public Animator eye13Anim;
    public Animator eye14Anim;
    public Animator eye15Anim;

    public Slider eyeSlider;


    [Space]
    [Header("ShapeUpgrade")]

    public Animator shapeAnim;

    public int maxShape;
    public int shapesBought;


    public int foodBeforeNextShape;
    public Button shapeButton;

    public PlayerMovement playerScript;

    [Space]
    [Header("Size Upgrade")]

    public int maxSize;
    public int sizesBought;


    public int foodBeforeNextSize;
    public Button sizeButton;

    










    public void PlaySound()
    {
        FindObjectOfType<AudioManager>().Play("Upgrade");

    }



    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Blink();
        }
        if (foodBeforeNextSize > ScoreManager.score)
        {
            sizeButton.interactable = false;
        }
        else
        {
            if (sizesBought == maxEyesight)
            {
                sizeButton.interactable = false;

            }
            else
            {
                sizeButton.interactable = true;

            }

        }
        if (foodBeforeNextEyesight > ScoreManager.score)
        {
            eyeSightButton.interactable = false;
        }else
        {
            if (eyesightsBought == maxEyesight)
            {
                eyeSightButton.interactable = false;

            }else
            {
                eyeSightButton.interactable = true;

            }

        }
        if (foodBeforeNextShape > ScoreManager.score)
        {
            shapeButton.interactable = false;
        }
        else
        {
            if (shapesBought == maxShape)
            {
                shapeButton.interactable = false;

            }
            else
            {
                shapeButton.interactable = true;

            }

        }
    }



    public void Blink()
    {
        eyeSlider.value = eyeSlider.maxValue;
        eye1Anim.SetTrigger("Blink");
        eye2Anim.SetTrigger("Blink");
        eye3Anim.SetTrigger("Blink");
        eye4Anim.SetTrigger("Blink");
        eye5Anim.SetTrigger("Blink");
        eye6Anim.SetTrigger("Blink");
        eye7Anim.SetTrigger("Blink");
        eye8Anim.SetTrigger("Blink");
        eye9Anim.SetTrigger("Blink");
        eye10Anim.SetTrigger("Blink");
        eye11Anim.SetTrigger("Blink");
        eye12Anim.SetTrigger("Blink");
        eye13Anim.SetTrigger("Blink");
        eye14Anim.SetTrigger("Blink");
        eye15Anim.SetTrigger("Blink");

    }

    public void NextShape()
    {

        ScoreManager.score -= foodBeforeNextShape;
        shapesBought += 1;
        foodBeforeNextShape *= 2;
        if (shapesBought == 1)
        {
            shapeAnim.SetTrigger("NextShape");
            playerScript.speed += 2;
        }
        if (shapesBought == 2)
        {
            shapeAnim.SetTrigger("NextShape");

            playerScript.speed += 2;
        }




    }

    public void GrowPlayer()
    {
        sizesBought += 1;
        foodBeforeNextSize *= 2;

        StartCoroutine(GrowBigger());
        
    }



    IEnumerator GrowBigger()
    {
        yield return new WaitForSeconds(0.05f);
        player.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        yield return new WaitForSeconds(0.05f);
        player.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        yield return new WaitForSeconds(0.05f);
        player.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        yield return new WaitForSeconds(0.05f);
        player.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        yield return new WaitForSeconds(0.05f);
        player.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        
    


    }


    public void GrowCamera ()
    {
        eyeSlider.gameObject.SetActive (true);

        StartCoroutine(Grow());
        ScoreManager.score -= foodBeforeNextEyesight;
        eyesightsBought += 1;
        foodBeforeNextEyesight *= 2;
        if (eyesightsBought == 1)
        {
            eye1.SetActive(true);
            eyeSlider.maxValue = 50;
        }else
        {
            eye1.SetActive(false);

        }
        if (eyesightsBought == 2)
        {
            eye2.SetActive(true);
            eyeSlider.maxValue = 40;

        }
        else
        {
            eye2.SetActive(false);

        }
        if (eyesightsBought == 3)
        {
            eye3.SetActive(true);
            eyeSlider.maxValue = 30;

        }
        else
        {
            eye3.SetActive(false);

        }
        if (eyesightsBought == 4)
        {
            eye4.SetActive(true);
            eyeSlider.maxValue = 20;

        }
        else
        {
            eye4.SetActive(false);

        }
        if (eyesightsBought > 4)
        {
            eye5.SetActive(true);
            eyeSlider.maxValue = 10;

        }
        else
        {
            eye5.SetActive(false);

        }

    }



    IEnumerator Grow()
    {
        Camera cameraScript = myCamera.GetComponent<Camera>();
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;
        yield return new WaitForSeconds(0.05f);
        cameraScript.orthographicSize += 0.05f;

        spawnpoint1.transform.position += spawnpoint1Offset;
        spawnpoint2.transform.position += spawnpoint2Offset;
        spawnpoint3.transform.position += spawnpoint3Offset;
        spawnpoint4.transform.position += spawnpoint4Offset;
        spawnpoint5.transform.position += spawnpoint5Offset;
        spawnpoint6.transform.position += spawnpoint6Offset;
        spawnpoint7.transform.position += spawnpoint7Offset;
        spawnpoint8.transform.position += spawnpoint8Offset;


    }

}
