using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public Shoot ball;
     public Transform spawnpoint;

   /* void Start()
    {
        spawnpoint = spawnpoint.transform;
    }
   */
   public void NextLevel()
    {
        Invoke("CompleteLevel", restartDelay);
    }

    public void CompleteLevel()
    {
        Debug.Log("LEvel wom");
        completeLevelUI.SetActive(true);
     
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("SES");
            Invoke("Respawna", restartDelay);
            // Restart game
          //  ball.counter += 3;

        }
    }
    public void Restart()
    {

       
     //   SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void Respawna()
    {
        
            ball.transform.position = spawnpoint.position;
            ball.counter = ball.counter += 2;

        gameHasEnded = false;
        
    }
}