using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	public GameObject spawnedBalls;
	private Vector3 mousePos;
	private Vector3 ballpos;

	private void Start()
	{
		
	}

	private void Update()
	{
		
		if(Input.GetMouseButtonDown(0))
        {
			
			Vector3 mousePos = Input.mousePosition;
			mousePos.z = 1;
			Vector3 ballpos = Camera.main.ScreenToWorldPoint(mousePos);
			Instantiate(spawnedBalls, ballpos, Quaternion.identity);
        }

	}


}