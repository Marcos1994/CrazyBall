using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public int velocidade { get; set; }
	public float turbo { get; set; }
	public float duracaoTurbo { get; set; }
	public bool estaNoChao;// { get; set; }
	private Rigidbody rb;

	void Start ()
	{
		velocidade = 40;
		turbo = 1.5F;
		duracaoTurbo = 0;
		estaNoChao = false;
		rb = gameObject.GetComponent<Rigidbody>();
		gameObject.GetComponent<Renderer>().material.color = new Color(0.5F, 0.5F, 0.5F, 0.5F);
	}
	
	void Update ()
	{
		estaNoChao = Physics.Raycast(transform.position, -Vector3.up, 0.51f);

		if (Input.anyKey)
		{
			rb.AddForce(new Vector3(Input.GetAxis("Horizontal") * velocidade, 0, Input.GetAxis("Vertical") * velocidade));
			if (estaNoChao && Input.GetKeyDown(KeyCode.Space))
				rb.AddForce(new Vector3(0, 3000, 0));
		}

		gameObject.GetComponent<Renderer>().material.color = new Color(Mathf.Clamp(rb.velocity.x,-0.5F, 0.5F) + 0.5F, Mathf.Clamp(rb.velocity.y, -0.5F, 0.5F) + 0.5F, Mathf.Clamp(rb.velocity.z, -0.5F, 0.5F) + 0.5F, 0.5F);
	}
}
