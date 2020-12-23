using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TenMinutesScore : MonoBehaviour
{

    public Text scoreText;
    public Hexagon hexagon;
   

    void Update()
    {
        if(hexagon.transform.localScale.x <= .05f)
        {
            scoreText.text += hexagon.transform.position.x.ToString("0");
        }
        
    }
}
