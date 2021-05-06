using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{

    

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Water")
        {
            FindObjectOfType<AudioManager>().Play("Plask");
            FindObjectOfType<GameManager>().EndGame();

        }
          if (collisionInfo.collider.tag == "Hole")
          {
            FindObjectOfType<AudioManager>().Play("HoleSound");
            Debug.Log("You wind");
              FindObjectOfType<GameManager>().NextLevel();

              // Här ska vi ändra till next hole.
          }
      }
    }

