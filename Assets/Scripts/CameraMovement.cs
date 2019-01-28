using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject View;
    public GameObject CanvMenu;
    public GameObject CanvFrase;

    public int navs;

    // Use this for initialization
    void Start ()
    {
        navs = 0;
    }
    
    // Update is called once per frame
    void Update ()
    {
        if (navs == 0)
        {
            View.transform.position = CanvMenu.transform.position + new Vector3(0, 0, -CanvMenu.transform.position.z) ;
        }
        else if (navs == 1)
        {
            View.transform.position = CanvFrase.transform.position + new Vector3(0, 0, -CanvFrase.transform.position.z);
        }
    }

    public void MoveToFrase()
    {
        navs = 1;
    }

    public void Back()
    {
        navs = 0;
    }
}
