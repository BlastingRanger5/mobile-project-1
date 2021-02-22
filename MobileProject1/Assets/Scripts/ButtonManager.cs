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
    public Text aStory;
    public Text aStory2;
    public Text aStory3;
    public Text aStory4;
    public Text aStory5;
    public Text aStory6;
    public Text aStory7;
    public Text aStory8;
    public Text aStory9;
    public Button answer1;
    public Button answer2;

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

    public void WrongAnswer5()
    {
        Debug.Log("*boom*");
        boom.Play(0);
        StartCoroutine(postButton());
    }

    public void WrongAnswer6()
    {
        Debug.Log("*boom*");
        connellyText.enabled = false;
        minecraft.enabled = false;
        lightningBolt.enabled = false;
        answer1.enabled = false;
        answer2.enabled = false;
        boom.Play(0);
        StartCoroutine(postButton4());
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

    IEnumerator postButton4()
    {
        yield return new WaitForSeconds(6f);
        aStory.enabled = true;
        yield return new WaitForSeconds(6f);
        aStory.enabled = false;
        aStory2.enabled = true;
        yield return new WaitForSeconds(6f);
        aStory2.enabled = false;
        aStory3.enabled = true;
        yield return new WaitForSeconds(6f);
        aStory3.enabled = false;
        aStory4.enabled = true;
        yield return new WaitForSeconds(6f);
        aStory4.enabled = false;
        aStory5.enabled = true;
        yield return new WaitForSeconds(6f);
        aStory5.enabled = false;
        aStory6.enabled = true;
        yield return new WaitForSeconds(6f);
        aStory6.enabled = false;
        aStory7.enabled = true;
        yield return new WaitForSeconds(6f);
        aStory7.enabled = false;
        aStory8.enabled = true;
        yield return new WaitForSeconds(6f);
        aStory8.enabled = false;
        aStory9.enabled = true;
        yield return new WaitForSeconds(6f);
        aStory9.text = "Music by Winchester Cathedral Choir";
        yield return new WaitForSeconds(5f);
        Debug.Log("bye");
        Application.Quit();
    }

}
