using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMoveLeft : MonoBehaviour
{
    Rigidbody2D rb;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(-10.0f, -25.0f);
        Vector2 position = rb.position;
        position.x = position.x + 3.0f * speed * Time.deltaTime;
        rb.MovePosition(position);
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        //destroycars
        if (other.tag == "Outside")
        {
            Destroy(gameObject);
        }
    }
}
