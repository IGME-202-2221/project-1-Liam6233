using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    TextMesh healthPrefab;

    [SerializeField]
    TextMesh scorePrefab;

    [SerializeField]
    GameObject player;

    GameObject playerHealth;
    GameObject playerScore;
    GameObject gameTime;

    float timer = 0;
    void Start()
    {
        healthPrefab.text = "Health: " + player.GetComponent<Player>().health;
        playerHealth = Instantiate(healthPrefab.gameObject, new Vector3(-8.5f, 5f, 0), Quaternion.identity, transform);

        scorePrefab.text = "Score: " + player.GetComponent<Player>().score;
        playerScore = Instantiate(scorePrefab.gameObject, new Vector3(-8.5f, -4, 0), Quaternion.identity, transform);

        gameTime = Instantiate(healthPrefab.gameObject, new Vector3(-8.5f, 4.2f, 0), Quaternion.identity, transform);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        playerHealth.GetComponent<TextMesh>().text = "Health: " + player.GetComponent<Player>().health;
        playerScore.GetComponent<TextMesh>().text = "Score: " + player.GetComponent<Player>().score;
        gameTime.GetComponent<TextMesh>().text ="Time Survived: " + ((int)timer).ToString();
    }
}
