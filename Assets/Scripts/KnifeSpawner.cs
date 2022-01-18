/*This script is attached to empty gameobject
 * it only spawns the knife and counts them.
 * after certain amount of knives the spawner stops spawning knives.
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawner : MonoBehaviour
{
    public GameObject knife;
    public int remainingKnifes = 7;
    //private Rigidbody knifeRigidbody;
    //private float throwForce = 1000.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {

        //knifeRigidbody = knife.GetComponent<Rigidbody>();

        
    }
    void Update()
    {

        ThrowKnife();
        
            
    }
    void ThrowKnife()
    {
        if (Input.GetKeyDown(KeyCode.S) && remainingKnifes > 0)
        {
            //knifeRigidbody.AddForce(Vector3.up * throwForce, ForceMode.VelocityChange);
            Instantiate(knife, transform.position, knife.transform.rotation);
            Debug.Log("Knifes Remaining : " + remainingKnifes);
            remainingKnifes--;
        }
    }
}
