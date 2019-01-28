using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMovement : MonoBehaviour
{
    int side = 1;
    float segundo = 2.0f;

	void Update ()
    {
        segundo = segundo - Time.deltaTime;
        if (segundo < 0)
        {
            segundo = 2.0f;
            side *= -1;
        }
        transform.localScale += (side * new Vector3(0.07f, 0.07f, 0) * Time.deltaTime);
    }
}
