using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour


{
    public SceneTransitions sceneTrans;
    public string sceneName;
    public void Begin()
    {
        sceneTrans.LoadScene(sceneName);
        FindObjectOfType<AudioManager>().Play("Menu");

    }

    public void Tutorial()
    {
        sceneTrans.LoadScene("Tutorial");
        FindObjectOfType<AudioManager>().Play("Menu");

    }
}
