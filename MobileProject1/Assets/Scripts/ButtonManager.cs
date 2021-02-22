using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    public Image explosion;
    public Image zeusHair;
    public Image zeusHair2;
    public Image zeusHair3;
    public Image zeusHair4;
    public Image zeusHair5;
    public Image zeusHair6;
    public Image zeusHair7;
    public Image lightningBolt;
    public Rigidbody2D rb;
    public AudioSource boom;
    public Text connellyText;
    public Text minecraft;
    public Text minecraftTwo;

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

    public void WrongAnswer2()
    {
        Debug.Log("*boom*");
        connellyText.enabled = true;
        explosion.enabled = true;
        boom.Play(0);
        StartCoroutine(postButton());
    }

    public void WrongAnswer3()
    {
        Debug.Log("*boom*");
        rb.simulated = true;
        StartCoroutine(postButton2());
    }

    public void WrongAnswer4()
    {
        Debug.Log("*boom*");
        connellyText.enabled = true;
        zeusHair.enabled = true;
        zeusHair2.enabled = true;
        zeusHair3.enabled = true;
        zeusHair4.enabled = true;
        zeusHair5.enabled = true;
        zeusHair6.enabled = true;
        zeusHair7.enabled = true;
        lightningBolt.enabled = true;
        StartCoroutine(postButton3());
    }

    IEnumerator postButton()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("bye");
        Application.Quit();
    }

    IEnumerator postButton2()
    {
        yield return new WaitForSeconds(2f);
        boom.Play(0);
        yield return new WaitForSeconds(1f);
        minecraft.enabled = true;
        minecraftTwo.enabled = true;
        yield return new WaitForSeconds(1f);
        Debug.Log("bye");
        Application.Quit();
    }

    IEnumerator postButton3()
    {
        yield return new WaitForSeconds(2f);
        explosion.enabled = true;
        boom.Play(0);
        yield return new WaitForSeconds(2f);
        Debug.Log("bye");
        Application.Quit();
    }

}
