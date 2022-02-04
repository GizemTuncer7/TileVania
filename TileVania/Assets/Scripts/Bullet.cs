using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D myRigidBody;
    [SerializeField]
    float bulletSpeed;
    PlayerMovement player;
    float xSpeed;
       void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        player=FindObjectOfType<PlayerMovement>();
        xSpeed = player.transform.localScale.x*bulletSpeed;
    }

    
    void Update()
    {
        myRigidBody.velocity = new Vector2(xSpeed, 0f);   
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }   
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
       Destroy (gameObject);
    }
}
