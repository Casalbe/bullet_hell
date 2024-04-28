using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class plantShotLeft : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(1, 0).normalized * force;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collider){
        if(!collider.CompareTag("Enemy") && !collider.CompareTag("Bullet")){
            Destroy(gameObject);
        }
        
    }
}
