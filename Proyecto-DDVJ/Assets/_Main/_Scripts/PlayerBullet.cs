using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //old bullet
        Vector2 position = transform.position;

        //new position
        position = new Vector2(position.x, position.y + speed * Time.deltaTime);

        //actualice bullet position
        transform.position = position;

        //top-right point of screen
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2 (1,1));
        //bullet goes away screen
        if (transform.position.y > max.y)
        {
            Destroy(gameObject);
        }
        //
    }
}
