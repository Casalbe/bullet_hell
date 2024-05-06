using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pausePanel;
    public bool pauseState = false;
    void Start()
    {
        pausePanel.SetActive(pauseState);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(pauseState == false){
                pauseGame();
            }else{
                resumeGame();
            }
        }
    }

    public void pauseGame(){
        pausePanel.SetActive(!pauseState);
        Time.timeScale = 0f;
        pauseState = !pauseState;
    }

    public void resumeGame(){
        pausePanel.SetActive(!pauseState);
        Time.timeScale = 1f;
        pauseState = !pauseState;
    }

}
