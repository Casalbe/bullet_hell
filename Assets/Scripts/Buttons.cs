using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public static double jumpPrice = 10;
    public static double speedPrice = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart(){
        SceneManager.LoadSceneAsync("bullet hell");
    }

    public void upgrades(){
        SceneManager.LoadSceneAsync("upgradeScreen");
    }

    public void jumpUpgrade(){
        if(PlayerMovement.jumpingPower < 10f && Point.pointAmount >= jumpPrice){
            PlayerMovement.jumpingPower += 1f;
            Point.pointAmount -= jumpPrice;
            jumpPrice = Math.Floor(jumpPrice * 1.5);
        }
    }

    public void speedUpgrade(){
        if(PlayerMovement.speed < 10 && Point.pointAmount >= speedPrice){
            PlayerMovement.speed += 1;
            Point.pointAmount -= speedPrice;
            speedPrice = Math.Floor(speedPrice * 1.5);
        }
    }

    public void screenWipeEnable(){
        if(Point.pointAmount >= 50 && !Powers.screenWipeEnabled){
            Point.pointAmount -= 50;
            Powers.screenWipeEnabled = true;
        }
    }

    public void crouchEnable(){
        if(Point.pointAmount >= 20 && !PlayerMovement.canCrouch){
            Point.pointAmount -= 20;
            PlayerMovement.canCrouch = true;
        }
    }

    public void mainMenu(){
        SceneManager.LoadSceneAsync("Main Menu scene");
    }
}
