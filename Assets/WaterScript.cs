using UnityEngine;

public class WaterScript : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        Debug.Log("Prank");
    }
    void Update()
    {
        
    }
}
