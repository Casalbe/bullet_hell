using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
    public bool screenWipeEnabled = false;
    public float screenWipeCooldown = 0f;
    public GameObject[] bulletList;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r") && screenWipeEnabled && screenWipeCooldown <= 0){
            bulletList = GameObject.FindGameObjectsWithTag("Bullet");
            for(int i = 0; i < bulletList.Length;i++){
                Point.pointAmount += bulletList.Length;
                Destroy(bulletList[i]);
            }
        }
    }
}
