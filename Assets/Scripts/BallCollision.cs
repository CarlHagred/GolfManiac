using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
   
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Water")
        {
            FindObjectOfType<GameManager>().EndGame();
            
        }
        if (collisionInfo.collider.tag == "Hole")
        {
            Debug.Log("You wind");
            FindObjectOfType<GameManager>().NextLevelLoad();
           
            // Här ska vi ändra till next hole.
        }
    }
}
