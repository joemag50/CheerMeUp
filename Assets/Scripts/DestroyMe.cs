using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    float segundo = 2f;
    float side;

    private void Start()
    {
        side = (Random.value * 2.0f) - 1.0f;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 0.1f) * 40 * side);
        segundo = segundo - Time.deltaTime;
        if (segundo < 0)
        {
            segundo = 5.0f;
            Destroy(gameObject);
        }
    }
}
