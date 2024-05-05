using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekingShot : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public float force;
    private float timer;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        if(timer > 4){
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(!collider.CompareTag("Enemy") && !collider.CompareTag("Bullet")){
            Point.pointAmount++;
            Destroy(gameObject);
        }
    }
}
