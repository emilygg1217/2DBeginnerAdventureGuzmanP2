using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Rendering;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;
    public float changeTime = 3.0f;

    Rigidbody2D rigidbody2d;

    float timer;
    
        int direction = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        if(vertical)
        {
            position.y = position.y + Time.deltaTime * speed;

        }
        else
        {
            position.x = position.x + Time.deltaTime * speed;
        }
        

        rigidbody2d.MovePosition(position);
    }
}
