using UnityEngine;
using System.Collections;

public class GatilhoAcao : Coletavel
{
	public GameObject objeto;

	public override void coletar()
	{
		objeto.GetComponent<AcaoObjeto>().ativar();
	}
}
