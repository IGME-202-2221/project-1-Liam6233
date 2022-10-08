using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update

    Vector2 position;
    Vector2 velocity;
    
    Bounds bulletBounds;
    float timer;
    void Start()
    {
        bulletBounds = this.GetComponent<SpriteRenderer>().bounds;
        timer = 0;
        position = transform.position;
        velocity = new Vector2(7, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1f)
        {
            Destroy(gameObject);
        }

        position += velocity * Time.deltaTime;
        transform.position = position;

    }
}
