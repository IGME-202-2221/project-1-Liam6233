using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public int health = 10;

    [SerializeField]
    GameObject bulletPrefab;

    [SerializeField]
    CollisionManager colManager;

    float iframes = 0;
    public int Health
    {
        set { health = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            
            Destroy(this.gameObject);
        }
        if(health > 10)
        {
            health = 10;
        }

        // early implementation of Iframes so player does not instanly die on contact with things
        iframes += Time.deltaTime;
        if(iframes <= 2)
        {
            health++;
        }
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        // fires a bullet when player presses correct button
        Vector2 bulletPosition = new Vector2(transform.position.x + GetComponent<SpriteRenderer>().bounds.size.x/2, transform.position.y);
        if (context.performed)
        {
            colManager.AddBulletToList(Instantiate(bulletPrefab, bulletPosition, Quaternion.identity));
        }
    }

    public void LoseHealth()
    {
        health--;
        iframes = 0;
    }
}
