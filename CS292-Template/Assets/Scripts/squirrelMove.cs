using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squirrelMove : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 75.0f;

    public int acornCount;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        acornCount = 0;
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = rb.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rb.MovePosition(position);
    }
    public void ChangeAcornCount(int amount)
    {
        acornCount += 1;
    }
}