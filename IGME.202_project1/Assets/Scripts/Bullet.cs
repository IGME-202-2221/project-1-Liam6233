using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update

    Vector2 position;

    [SerializeField]
    Vector2 velocity;
    
    
    float timer;
    public bool hitEnemy = false;

    void Start()
    {
        timer = 0;
        position = transform.position;
        
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
