using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Lookdir = (player.transform.position - rb.position).normalized; 
        rb.AddForce(Lookdir * speed);
        if(transform.position.y <= -10)
        {
            Destroy(gameObject);
        }
    }
}
