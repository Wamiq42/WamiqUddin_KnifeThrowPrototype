/*This Script is for knives and there mechanics.
 * In Update method,When Space is pressed some force is applied on Knife.
 * the collisiondetector return bool value to make the knife Kinematic
 * the knifeCollisiondetector returns bool value to detect collision only between knives
 * and destroy the board Gameobject and turns off the spawn game object
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KnifeScript : MonoBehaviour
{
    private bool collisionDetector = false;
    private bool knifeCollisionDetector = false;
    Rigidbody knifeRigidbody;
    private float throwForce = 30.0f;
    private GameObject spawn, board,cubeSpawner;
    
   
    // Start is called before the first frame update
    void Start()
    {
        knifeRigidbody = gameObject.GetComponent<Rigidbody>();
        spawn = GameObject.FindWithTag("Spawner");
        board = GameObject.FindWithTag("Board");
       
    }

    // Update is called once per frame
    void Update()
    {

        //adds force
        if (Input.GetKeyDown(KeyCode.Space))
        {
            knifeRigidbody.AddForce(Vector3.up * throwForce, ForceMode.Impulse);
        }


        //makes the gameobject kinematic
        if (collisionDetector)
        {
            knifeRigidbody.isKinematic = true;
            collisionDetector = false;
        }


        //Game Over You Lose.
        if(knifeCollisionDetector)
        {
            spawn.SetActive(false);
            Destroy(board);
            Debug.Log("Game Over");

        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Board"))
        {
              collisionDetector = true;
            //collision.transform.parent = transform;
        }
        if(collision.gameObject.CompareTag("Knife"))
        { 
            knifeCollisionDetector = true;
        }
    }
}
