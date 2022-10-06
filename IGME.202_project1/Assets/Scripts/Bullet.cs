using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    CollisionManager colManager;

    Vector2 position;
    Vector2 velocity;
    bool alive;

    public bool Alive
    {
        get { return alive; }
        set { alive = value; }
    }
    Bounds bulletBounds;
    float timer;
    void Start()
    {
        alive = true;
        bulletBounds = this.GetComponent<SpriteRenderer>().bounds;
        timer = 0;
        position = transform.position;
        velocity = new Vector2(7, 0);
        colManager.AddBulletToList(this.gameObject);
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
