using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2f;
    private float repeatDelay = 2f;
    private PlayerController playerControllerScript;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
}
