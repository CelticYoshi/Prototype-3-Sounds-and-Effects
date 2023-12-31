using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    
    private float startDelay = 2;
    private float repeatRate = 2;
    private Vector3 _spawnPos = new Vector3(25, 0, 0);
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.GameOver == false)
        {
            Instantiate(obstaclePrefab, _spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
