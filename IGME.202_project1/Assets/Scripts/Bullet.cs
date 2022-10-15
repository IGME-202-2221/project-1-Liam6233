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
    public bool hitEnemy = false;

    void Start()
    {
        bulletBounds = this.GetComponent<SpriteRenderer>().bounds;
        timer = 0;
        position = transform.position;
        velocity = new Vector2(700, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1f)
        {
            DestroyBullet();
        }

        position += velocity * Time.deltaTime;
        transform.position = position;

    }


    public void AddToTimer()
    {
        timer += 100000000f;
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
