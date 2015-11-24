using UnityEngine;
using System.Collections;

public abstract class Coletavel : MonoBehaviour
{
	private float v1, v2, v3;
	private float tempo;

	void Start()
	{
		v1 = v2 = v3 = 1;
		gameObject.GetComponent<Renderer>().material.color = new Color(v1/2, v2/2, v3/2, 0.5F);
	}

	void Update ()
	{
		if ((tempo += Time.deltaTime) > 2)
		{
			tempo = 0;
			v1 = Random.Range(0F, 2F);
			v2 = Random.Range(0F, 2F);
			v3 = Random.Range(0F, 2F);
			gameObject.GetComponent<Renderer>().material.color = new Color(v1/2, v2/2, v3/2, 0.25F);
		}

		transform.Rotate(Vector3.right, v1);
		transform.Rotate(Vector3.forward, v2);
		transform.Rotate(Vector3.up, v3);
	}

	void OnTriggerEnter(Collider coll)
	{
		if (coll.gameObject.tag == "Player")
			coletarObjeto();
	}

	protected void coletarObjeto()
	{
		coletar();
		Destroy(gameObject);
	}

	public abstract void coletar();
}
