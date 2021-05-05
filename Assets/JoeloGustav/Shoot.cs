using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shoot : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;

    public Vector2 minPower;
    public Vector2 maxPower;
    public float counter = 0;

    Trajector traj;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;

   public  Vector3 lastPosition;
    Transform myTransform;
    bool isMoving;
   


    private void Start()
    {
        cam = Camera.main;
        traj = GetComponent<Trajector>();

        myTransform = transform;
        lastPosition = myTransform.position;
        isMoving = false;
    }

    private void FixedUpdate()
    {
        if (rb.position.y < -7f)
        {
            FindObjectOfType<GameManager>().EndGame();

       
        }


        if (myTransform.position != lastPosition)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        lastPosition = myTransform.position;

        if (isMoving != true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                startPoint.z = 15;
               
            }
            if (Input.GetMouseButton(0))
            {
                Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                currentPoint.z = 15;

                traj.RenderLine(startPoint, currentPoint);

            }
            if (Input.GetMouseButtonUp(0))
            {
                endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                endPoint.z = 15;



                force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
                rb.AddForce(force * power, ForceMode2D.Impulse);
                //Camera.main.gameObject.transform.Translate(startPoint.x - endPoint.x, 1, 1);
                traj.EndLine();
                counter += 1;
                Debug.Log(counter);
                Debug.Log(lastPosition);
            }
        }
    }
  

   

}
