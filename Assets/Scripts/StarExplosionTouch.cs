using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarExplosionTouch : MonoBehaviour
{
	public GameObject StarPrefab;

	void Start ()
	{
		
	}

	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 pos = Input.mousePosition;
 			pos.z = 10.0f;
 			pos = Camera.main.ScreenToWorldPoint(pos);
			Explosion(pos);
		}

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
        }
	}

	void Explosion (Vector3 pos)
	{
		Instantiate(StarPrefab, pos, Quaternion.identity);
	}
}
