using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    public Image explosion;
    public AudioSource boom;

    void Start()
    {
        
    }

    public void RightAnswer()
    {
        Debug.Log("YESSIREE");
    }

    public void WrongAnswer1()
    {
        Debug.Log("*boom*");
        explosion.enabled = true;
        boom.Play(0);
        StartCoroutine(postButton());
    }

    IEnumerator postButton()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("bye");
        Application.Quit();
    }

}
