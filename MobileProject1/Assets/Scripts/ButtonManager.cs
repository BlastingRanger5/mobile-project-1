using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    void Start()
    {
        
    }

    public void RightAnswer()
    {
        Debug.Log("YESSIREE");
    }

    public void WrongAnswer()
    {
        Debug.Log("*boom*");
    }
}
