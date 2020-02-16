using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squirrelMove : MonoBehaviour{

    Rigidbody2D rb;
    float speed = 75.0f;

    public int acornCount;
    public Joystick joystick;
    public static bool dead = false;


    void Start(){
        rb = GetComponent<Rigidbody2D>();
        acornCount = 0;
    }


    void Update(){
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;
        Vector2 position = rb.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rb.MovePosition(position);
    }


    public void ChangeAcornCount(int amount){
        acornCount += 1;
    }

    // Destroy the Squirrel
    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Vehicle"){
            dead = true;
            Destroy(gameObject);
        }
    }

}
