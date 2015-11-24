using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
	private GameObject player;

	void Start ()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update ()
	{
		gameObject.transform.position = player.transform.position;
	}
}
