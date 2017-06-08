using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{

    public float timer;

    public GameObject pickup;
	// Use this for initialization
	void Start ()
	{
	    float timer = 20.0f;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    timer -= 1;
	    if (timer <= 0)
	    {
	        Instantiate(pickup);
	    }
	}
}
