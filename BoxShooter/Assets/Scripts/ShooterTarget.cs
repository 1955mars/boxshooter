using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterTarget : MonoBehaviour {

    // Reference to projectile prefab to shoot
    public GameObject projectile;
    public float power = 10.0f;
    //public GameObject Target;
    //public float shootingFreq = 0.5f;

    // Reference to AudioClip to play
    public AudioClip shootSFX;


    private float nextShootTime;
    private GameObject Target;
    private int scoreAmount = 0;
    private float timeAmount = 0.0f;


    void Start()
    {
        nextShootTime = Time.time;
        Target = GameObject.FindGameObjectWithTag("Player");
        scoreAmount = gameObject.GetComponent<TargetBehavior>().scoreAmount;
        timeAmount = gameObject.GetComponent<TargetBehavior>().timeAmount;
    }

    // Update is called once per frame
    void Update()
    {

        // exit if there is a game manager and the game is over
        if (GameManager.gm)
        {
            if (GameManager.gm.gameIsOver)
                return;
        }

        //transform.LookAt(Target.transform);
        // Detect if fire button is pressed
        if (Time.time >= nextShootTime) 
        {
            // if projectile is specified
            if (projectile)
            {

                Vector3 targetPos = Target.transform.position;

                Vector3 toPlayerVec = targetPos - transform.position;

                toPlayerVec = toPlayerVec.normalized;   

                GameObject newProjectile = Instantiate(projectile, transform.position + 2 * toPlayerVec, transform.rotation) as GameObject;

                // if the projectile does not have a rigidbody component, add one
                if (!newProjectile.GetComponent<Rigidbody>())
                {
                    newProjectile.AddComponent<Rigidbody>();
                }

                newProjectile.GetComponent<Projectile2>().scoreAmout = scoreAmount;
                newProjectile.GetComponent<Projectile2>().timeAmount = timeAmount;

                // Apply force to the newProjectile's Rigidbody component if it has one
                newProjectile.GetComponent<Rigidbody>().AddForce(toPlayerVec * power, ForceMode.VelocityChange);




                // play sound effect if set
                if (shootSFX)
                {
                    if (newProjectile.GetComponent<AudioSource>())
                    { // the projectile has an AudioSource component
                      // play the sound clip through the AudioSource component on the gameobject.
                      // note: The audio will travel with the gameobject.
                        newProjectile.GetComponent<AudioSource>().PlayOneShot(shootSFX);
                    }
                    else
                    {
                        // dynamically create a new gameObject with an AudioSource
                        // this automatically destroys itself once the audio is done
                        AudioSource.PlayClipAtPoint(shootSFX, newProjectile.transform.position);
                    }
                }
            }
            nextShootTime = Time.time + 2.0f;//(Random.Range(1,10) / 5);
        }
    }
}
