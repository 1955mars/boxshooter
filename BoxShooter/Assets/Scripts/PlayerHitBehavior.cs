using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBehavior : MonoBehaviour {

    // target impact on game
    private int scoreAmount = 0;
    private float timeAmount = 0.0f;

    // when collided with another gameObject
    void OnCollisionEnter(Collision newCollision)
    {

        Debug.Log("On collison enter");
        // exit if there is a game manager and the game is over
        if (GameManager.gm)
        {
            if (GameManager.gm.gameIsOver)
                return;
        }

        // only do stuff if hit by a projectile
        if (newCollision.gameObject.tag == "Projectile2")
        {

            // if game manager exists, make adjustments based on target properties
            if (GameManager.gm)
            {
                Debug.Log("Game Manager exists");
                scoreAmount = newCollision.gameObject.GetComponent<Projectile2>().scoreAmout;
                timeAmount = newCollision.gameObject.GetComponent<Projectile2>().timeAmount;
                Debug.Log("scoreAmount = " + scoreAmount);
                Debug.Log("timeAmount = " + timeAmount);
                GameManager.gm.PlayerHit(scoreAmount, timeAmount);
            }

            // destroy the projectile
            Destroy(newCollision.gameObject);

        }
    }
}
