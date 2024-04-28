using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant : MonoBehaviour
{
    private float timer;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletPos;
    private int shots = 0;
    private int maxShots = 3;

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
            shots++;
        }
        if(shots == maxShots){
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
