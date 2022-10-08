using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CollisionManager : MonoBehaviour
{
    [SerializeField]
    GameObject ship;

    [SerializeField]
    GameObject playerBulletPrefab;

    SpriteRenderer shipColor;

    [SerializeField]
    List<GameObject> enemyList;

    public List<GameObject> bulletList;

    // Start is called before the first frame update
    void Start()
    {
        shipColor = ship.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = ship;
        GameObject enemy;
        bool playerCollision;
        bool bulletCollision;
        shipColor.color = Color.white;
        for (int i = 0; i < enemyList.Count; i++)
        {
            if (enemyList[i] != null)
            {
                enemy = enemyList[i];
            }
            else
            {
                enemyList.RemoveAt(i);
                i--;
                continue;
            }
            
            playerCollision = AABBCollision(player, enemy);
            
            if (playerCollision)
            {
                shipColor.color = Color.red;
                ship.GetComponent<Player>().LoseHealth();
                enemyList[i].GetComponent<SpriteRenderer>().color = Color.red;
                enemyList[i].GetComponent<Enemy>().TakeDamage();
                i = enemyList.Count;
            }
            else 
            {
                enemyList[i].GetComponent<SpriteRenderer>().color = Color.white;
            }

            for(int j = 0; j < bulletList.Count; j++)
            {
                if(bulletList[j] != null)
                {
                    bulletCollision = AABBCollision(bulletList[j], enemy);
                    if (bulletCollision)
                    {
                        enemyList[i].GetComponent<SpriteRenderer>().color = Color.red;
                        enemyList[i].GetComponent<Enemy>().TakeDamage();
                    }
                }
                
            }
        }   
        clearBulletList();
    }

    public bool AABBCollision(GameObject player, GameObject obstical)
    {
        bool areColliding = false;
        Bounds playerBox = player.GetComponent<SpriteRenderer>().bounds;
        Bounds obsticalBox = obstical.GetComponent<SpriteRenderer>().bounds;

        if (obsticalBox.min.x < playerBox.max.x &&
            obsticalBox.max.x > playerBox.min.x &&
            obsticalBox.max.y > playerBox.min.y &&
            obsticalBox.min.y < playerBox.max.y)
        {
            areColliding = true;
        }
        return areColliding;
    }

    public void AddEnemyToList(Enemy obj)
    {
        enemyList.Add(obj.gameObject);
    }

    public void AddBulletToList(GameObject obj)
    {
        bulletList.Add(obj);
    }

    private void clearBulletList()
    {
        for(int i = 0; i < bulletList.Count; i++)
        {
            if (bulletList[i] == null)
            {
                bulletList.RemoveAt(i);
            }
        }
    }
}
