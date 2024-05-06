using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class inGameHud : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    public TextMeshProUGUI screenWipeCD;
    public Image screenWipeImg;

    void Start()
    {
        pointText.text = Point.pointAmount.ToString() + " points";
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = Point.pointAmount.ToString() + " points";

        if(!Powers.screenWipeEnabled || Powers.screenWipeCooldown <= 0){
            screenWipeCD.text = "";
        }else{
            screenWipeCD.text = Math.Floor(Powers.screenWipeCooldown).ToString();
        }

        if(Powers.screenWipeEnabled){
            var tempColor = screenWipeImg.color;
            tempColor.a = 255f;
            screenWipeImg.color = tempColor;
        }
    }
}
