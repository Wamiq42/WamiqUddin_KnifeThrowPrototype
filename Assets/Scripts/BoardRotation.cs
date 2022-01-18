/*This Scrip is for Board Rotation and collision detection.
 * In update method the rotation is set.
 * In collision Enter method the collisons are checked
 * If the collided object is knife with Board then the
 * knife becomes child or dervied object of Board Object.(to main the rotation of knives same as gameObject)
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardRotation : MonoBehaviour
{
    private float rotationSpeed = 140f;
    private int knifecounter;
  
  
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            if (knifecounter < 8)
            {
                collision.transform.parent = transform;
                knifecounter++;
            }

            if(knifecounter == 7)
                Destroy(gameObject); 

        }
    }
}
