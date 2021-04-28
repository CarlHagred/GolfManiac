using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("yoloi");
        if (collisionInfo.collider.tag == "Water")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
