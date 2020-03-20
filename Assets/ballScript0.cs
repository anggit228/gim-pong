using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript0 : MonoBehaviour
{
    public int speed=23;
    public Rigidbody2D ball;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Game!");
        ball.velocity = new Vector2(1,-1) * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.name=="rightWall" || other.collider.name=="leftWall"){
            GetComponent<Transform>().position = new Vector2(0,0);
        }
    }
}
