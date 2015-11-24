using UnityEngine;
using System.Collections;

public class MovimentoPonte : AcaoObjeto
{
	public override void ativar()
	{
		gameObject.transform.Rotate(90, 0, 0);
	}

	public override void desativar()
	{
		gameObject.transform.Rotate(0, 0, 0);
	}
}
