using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLimitCanvas : MonoBehaviour
{
    public GameObject limit;



    public void OverTheLimit()
    {
        limit.SetActive(true);
    }
}
