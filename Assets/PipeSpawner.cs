using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 8;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else if (!logic.isGameOver)
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y -heightOffset;
        float heighestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, transform.position, transform.rotation);
        // Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0), transform.rotation);
    }
}

    