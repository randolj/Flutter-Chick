using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic.isGameOver)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

            if (transform.position.x < deadZone)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
