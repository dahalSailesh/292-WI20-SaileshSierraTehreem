using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMoveLeft : MonoBehaviour{

    Rigidbody2D rb;
    float speed = -15.0f;

    
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update(){
        Vector2 position = rb.position;
        position.x = position.x + 3.0f * speed * Time.deltaTime;
        rb.MovePosition(position);
    }

    // Destroy cars
    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Outside"){
            Destroy(gameObject);
        }
    }

}
