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

    // reference to main camera
    Camera cam = Camera.main;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < enemyList.Count; i++)
        {
            if(enemyList[i] != null && enemyList[i].Health == 0 || enemyList[i].position.x < cam.rect.x)
            {
                clearEnemy(i);
                i--;
            }
        }
    }

    private void clearEnemy(int index)
    {
        Destroy(enemyList[index]);
        enemyList.RemoveAt(index);
    }

    private void SpawnEnemy()
    {
       
    }
}
