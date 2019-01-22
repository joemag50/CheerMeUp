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
		localCheers = new string[26];

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

		localCheers[10] = "Quiere a tu familia";
		localCheers[11] = "La vida en verdad es bella";
		localCheers[12] = "No estas solo";
		localCheers[13] = "Piensa antes de hablar";
		localCheers[14] = "Cuida a tus seres queridos";
		localCheers[15] = "Respetate, quierete a ti mismo";
		localCheers[16] = "Cuida tus impulsos";
		localCheers[17] = "Vive la vida";
		localCheers[18] = "Eres libre de pensar lo que deseas";
		localCheers[19] = "Cumple tus metas";
		localCheers[20] = "Da lo mejor de ti";
		localCheers[21] = "Da sin esperar a cambio";
		localCheers[22] = "Muchas personas pasan por lo mismo que tu";
		localCheers[23] = "Antes de hablar, primero escucha";
		localCheers[24] = "Conoce tus limites";
		localCheers[25] = "Visita a tus amigos";

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
