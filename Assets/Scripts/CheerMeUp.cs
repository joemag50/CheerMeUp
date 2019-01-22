using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheerMeUp : MonoBehaviour
{
	public GameObject letrero;
	string[] localCheers;

	void Start ()
	{
		//Load cheers from memory (Let 30 cheers in local)
		localCheers = new string[10];

		localCheers[0] = "Eres genial";
		localCheers[1] = "Tienes muchas cualidades buenas";
		localCheers[2] = "Eres una persona con mucho valor";
		localCheers[3] = "Hoy es tu día";
		localCheers[4] = "Sorprendete a ti mismo";
		localCheers[5] = "Sonrie, canta y rie";
		localCheers[6] = "Disfruta el momento";
		localCheers[7] = "Intenta algo diferente";
		localCheers[8] = "Retate a ti mismo";
		localCheers[9] = "Aceptate como eres";

		//Load cheers from server (async from heroku)
		//Set array of cheers
		//Initialize letrero
		letrero.GetComponent<TextMeshProUGUI>().text = "Haz click abajo";
	}

	void Update ()
	{
		
	}

	public void Cheer ()
	{
		//Roll the cheer in the screen
		int rand = Random.Range(0, localCheers.Length);
		letrero.GetComponent<TextMeshProUGUI>().text = localCheers[rand];
	}
}
