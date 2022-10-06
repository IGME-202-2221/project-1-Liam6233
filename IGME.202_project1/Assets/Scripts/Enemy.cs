using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    int health = 1;

    public Vector2 position;
    Vector2 velocity;

    // enemies will have a set path that they take, it is randomly chosen 
    // out of a few set paths
    // they include 1 Sinwave,2 straight line (may be at angle) 
    // 3 logarithmic, 
    // maybe 1 more
    int movementType;

    public int Health
    {
        get { return health; }
    }
    
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // based on movement type, posisition is updated using different math functions       
    }

    private void SetMovement()
    {
        movementType = Random.Range(1, 5);
        
    }
}
