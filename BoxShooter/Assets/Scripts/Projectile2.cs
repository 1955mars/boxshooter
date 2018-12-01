using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2 : MonoBehaviour
{

    public int scoreAmout { get; set; }
    public float timeAmount { get; set; }

    public GameObject explosionPrefab;

    public int scoreAmount = 0;

    // when collided with another gameObject
    void OnCollisionEnter(Collision newCollision)
    {
        // exit if there is a game manager and the game is over
        if (GameManager.gm)
        {
            if (GameManager.gm.gameIsOver)
                return;
        }

        if (newCollision.gameObject.tag == "Projectile")
        {
            GameManager.gm.targetHit(scoreAmount, 0.0f);

            if (explosionPrefab)
            {
                // Instantiate an explosion effect at the gameObjects position and rotation
                Instantiate(explosionPrefab, transform.position, transform.rotation);
            }

            Destroy(newCollision.gameObject);
            Destroy(gameObject);
        }
    }
}
