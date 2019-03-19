﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleLimiter : MonoBehaviour {

    private GameManager gmInstance;

    private void Start()
    {
        gmInstance = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Simply acts a limit for the obstacles, deleting them.
        if (collision.tag == "Obstacle")
        {
            ObstaclePawn obstaclePawn = collision.gameObject.GetComponent<ObstaclePawn>();
            Destroy(collision.gameObject, 1);
            gmInstance.ObstacleDodged(obstaclePawn.pointsAwarded);
        }   
    }
}