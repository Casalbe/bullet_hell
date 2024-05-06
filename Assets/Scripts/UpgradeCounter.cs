using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeCounter : MonoBehaviour
{
    public TextMeshProUGUI jumpCounter;
    public TextMeshProUGUI speedCounter;
    public TextMeshProUGUI crouchCounter;
    public TextMeshProUGUI wipeCounter;
    public TextMeshProUGUI pointText;

    void Start()
    {
        if(PlayerMovement.jumpingPower >= 8){
            jumpCounter.text = "Current speed: MAX";
        }else{
            jumpCounter.text = "("+ Buttons.jumpPrice + ")" + "Current jumping power: " + PlayerMovement.jumpingPower.ToString();
        }
        if(PlayerMovement.speed >= 10){
            speedCounter.text = "Current speed: MAX";
        }else{
            speedCounter.text = "("+ Buttons.speedPrice + ")" +  "Current speed: " + PlayerMovement.speed.ToString();
        }
        pointText.text = Point.pointAmount.ToString() + " points";
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.jumpingPower >= 8){
            jumpCounter.text = "Current speed: MAX";
        }else{
            jumpCounter.text = "("+ Buttons.jumpPrice + ")" + "Current jumping power: " + PlayerMovement.jumpingPower.ToString();
        }
        if(PlayerMovement.speed >= 10){
            speedCounter.text = "Current speed: MAX";
        }else{
            speedCounter.text = "("+ Buttons.speedPrice + ")" +  "Current speed: " + PlayerMovement.speed.ToString();
        }
        pointText.text = Point.pointAmount.ToString() + " points";

        if(PlayerMovement.canCrouch){
            crouchCounter.text = "Acquired";
        }else{
            crouchCounter.text = "(20)";
        }

        if(Powers.screenWipeEnabled){
            wipeCounter.text = "Acquired";
        }else{
            wipeCounter.text = "(50)";
        }
    }
}
