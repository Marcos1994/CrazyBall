using UnityEngine;
using System.Collections;

public class MovimentoPlataforma : AcaoObjeto
{
	private bool ativado = false;
	private int sentido = -1;
	private float distancia = 3;
	private float x;
	private float z;

	void Start()
	{
		x = gameObject.transform.position.x;
		z = gameObject.transform.position.z;
	}

	void Update()
	{
		if (ativado)
		{
			if (gameObject.transform.position.y > distancia)
				sentido = -1;
			else if (gameObject.transform.position.y < -distancia)
				sentido = 1;
			gameObject.transform.position = new Vector3(x, gameObject.transform.position.y + Time.deltaTime * sentido, z);
		}
	}

	public override void ativar()
	{
		ativado = true;
	}

	public override void desativar()
	{
		ativado = false;
	}
}
