using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLeft : MonoBehaviour
{
    private float timerSinceLastSpawn;
    private float timer;
    public float cooldown;
    public float maxCooldown;
    public float minCooldown;
    public GameObject enemy;
    public Transform[] positions;
    public int randomNum;
    // Start is called before the first frame update
    void Start()
    {
        randomNum = Random.Range(0, positions.Length);
        cooldown = Random.Range(minCooldown, maxCooldown);
    }

    // Update is called once per frame
    void Update()
    {
        timerSinceLastSpawn += Time.deltaTime;
        timer += Time.deltaTime;
        
        if(timerSinceLastSpawn > cooldown){
            timerSinceLastSpawn = 0;
            spawn(positions[randomNum]);
            randomNum = Random.Range(0, positions.Length);

            if(timer >= 10){
                minCooldown -= 0.5f;
                maxCooldown -= 1f;
            }
            cooldown = Random.Range(minCooldown, maxCooldown);
        }
        
    }

    public void spawn(Transform place){
        Instantiate(enemy, place.position, Quaternion.Euler(0,0,-90));
    }

}
