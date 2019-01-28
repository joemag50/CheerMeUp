using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngularMovement : MonoBehaviour
{
    int side = 1;
    float segundo = 4.0f;

	void Update ()
    {
        segundo = segundo - Time.deltaTime;
        if (segundo < 0)
        {
            segundo = 4.0f;
            side *= -1;
        }
        transform.Rotate(side * new Vector3(0, 0, 3) * Time.deltaTime);
    }
}
