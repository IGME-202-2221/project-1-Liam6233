using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject enemyBulletPrefab;

    [SerializeField]
    float shotInterval;

    float timer = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= shotInterval)
        {
            Vector2 bulletPosition = new Vector2(transform.position.x - GetComponent<SpriteRenderer>().bounds.size.x / 2, transform.position.y);
            
            Instantiate(enemyBulletPrefab, bulletPosition, Quaternion.identity);
            timer = 0;
        }
    }
}
