using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggEnemy : MonoBehaviour
{
    private float timer;
    public GameObject bullet;
    public Transform bulletPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1){
            timer = 0;
            shoot();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Player")){
            Destroy(gameObject);
        }
    }

    void shoot(){
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
