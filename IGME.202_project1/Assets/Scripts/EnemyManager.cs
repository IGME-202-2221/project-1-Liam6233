using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update

    // list containing all enemies that exist
    [SerializeField]
    List<Enemy> enemyList;

    [SerializeField]
    Enemy enemyPrefab;

    [SerializeField]
    public CollisionManager colManager;

    // reference to main camera
    [SerializeField]
    Camera cam;
    static float height;
    float width;
    void Start()
    {
        height = 2f * cam.orthographicSize;
        width = height * cam.aspect;
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    { 
        
        if (enemyList.Count == 0)
        {
            SpawnEnemy();
        }
        for(int i = 0; i < enemyList.Count; i++)
        {
            
            if(i< 0)
            {
                i = 0;
            }
            if (enemyList[i].position.x <= cam.transform.position.x - width / 2)
            {
                clearEnemy(i);
                
            }
            else if (enemyList[i].position.x >= cam.transform.position.x + width / 2)
            {
                enemyList[i].position.x = cam.transform.position.x + width / 2;
            }

            else if (enemyList[i].position.y < cam.transform.position.y - height / 2)
            {
                enemyList[i].position.y = cam.transform.position.y + height / 2;
            }

            else if (enemyList[i].position.y > cam.transform.position.y + height / 2)
            {
                enemyList[i].position.y = cam.transform.position.y - height / 2;
            }

            if (enemyList.Count != 0 && enemyList[i].Health == 0)
            {
                clearEnemy(i);

            }

        }
    }

    private void clearEnemy(int index)
    {
        Destroy(enemyList[index].gameObject);
        enemyList.RemoveAt(index);
    }

    private void SpawnEnemy()
    {
        // whenever spawn enemy is called, there is a random chance to spawn between 1 and 5 enemies
        for(int i = 0; i < Random.Range(1,6); i++)
        {
            float spawnHeight = Random.Range(-5f, 5f);
            Enemy newEnemy = Instantiate(enemyPrefab, new Vector2(cam.transform.position.x + width / 2, spawnHeight), Quaternion.identity,transform);
            enemyList.Add(newEnemy);
            colManager.AddEnemyToList(newEnemy);
        }
        
        
    }
}
