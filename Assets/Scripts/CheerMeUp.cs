using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class CheerMeUp : MonoBehaviour
{
	public GameObject letrero;
	public List<string> localCheersSpanish;
	public List<string> localCheersEnglish;
	public int Language;

	void Start ()
	{
		//Load cheers from memory
		localCheersSpanish = new List<string>();
		localCheersEnglish = new List<string>();
		//Joemag
		localCheersSpanish.Add("Eres genial");
		localCheersSpanish.Add("Tienes muchas cualidades buenas");
		localCheersSpanish.Add("Eres una persona con mucho valor");
		localCheersSpanish.Add("Hoy es tu día");
		localCheersSpanish.Add("Sorprendete a ti mismo");
		localCheersSpanish.Add("Sonrie, canta y rie");
		localCheersSpanish.Add("Disfruta el momento");
		localCheersSpanish.Add("Intenta algo diferente");
		localCheersSpanish.Add("Retate a ti mismo");
		localCheersSpanish.Add("Aceptate como eres");
		localCheersSpanish.Add("Quiere a tu familia");
		localCheersSpanish.Add("La vida en verdad es bella");
		localCheersSpanish.Add("No estas solo");
		localCheersSpanish.Add("Piensa antes de hablar");
		localCheersSpanish.Add("Cuida a tus seres queridos");
		localCheersSpanish.Add("Respetate, quierete a ti mismo");
		localCheersSpanish.Add("Cuida tus impulsos");
		localCheersSpanish.Add("Vive la vida");
		localCheersSpanish.Add("Eres libre de pensar lo que deseas");
		localCheersSpanish.Add("Cumple tus metas");
		localCheersSpanish.Add("Da lo mejor de ti");
		localCheersSpanish.Add("Da sin esperar a cambio");
		localCheersSpanish.Add("Muchas personas pasan por lo mismo que tu");
		localCheersSpanish.Add("Antes de hablar, primero escucha");
		localCheersSpanish.Add("Conoce tus limites");
		localCheersSpanish.Add("Visita a tus amigos");

		//Cheerfull people
		localCheersSpanish.Add("No esperes a que estés seguro, toma los riesgos");
		localCheersSpanish.Add("Échale ganas, las cervezas no se pagan solas");
		localCheersSpanish.Add("Los exitos vienen de los fracasos");
		localCheersSpanish.Add("Podría ser peor");
		localCheersSpanish.Add("Se paciente");
		localCheersSpanish.Add("Cuando te molesten por ser diferente, recuerda que ellos son iguales");
		localCheersSpanish.Add("No dejes que tu felicidad dependa de alguien más");
		localCheersSpanish.Add("Despues de la tormenta viene la calma");
		localCheersSpanish.Add("Llega hasta donde solo las aguilas y angeles pueden volar");
		localCheersSpanish.Add("La clave del cambio es liberarse del miedo");
		localCheersSpanish.Add("La barrera más grande del éxito es el miedo a la derrota");
		localCheersSpanish.Add("Por muy larga que sea la tormenta, el sol siempre vuelve a brillar entre las nubes");

		localCheersEnglish.Add ("You're great");
		localCheersEnglish.Add ("You have many good qualities");
		localCheersEnglish.Add ("You are a person with a lot of courage");
		localCheersEnglish.Add ("Today is your day");
		localCheersEnglish.Add ("Surprise yourself");
		localCheersEnglish.Add ("Smile, sing and laugh");
		localCheersEnglish.Add ("Enjoy the moment");
		localCheersEnglish.Add ("Try something different");
		localCheersEnglish.Add ("Challenge yourself");
		localCheersEnglish.Add ("Accept as you are");
		localCheersEnglish.Add ("Love your family");
		localCheersEnglish.Add ("Life is truly beautiful");
		localCheersEnglish.Add ("You are not alone");
		localCheersEnglish.Add ("Think before you speak");
		localCheersEnglish.Add ("Take care of your loved ones");
		localCheersEnglish.Add ("Love yourself");
		localCheersEnglish.Add ("Take care of your impulses");
		localCheersEnglish.Add ("Live the life");
		localCheersEnglish.Add ("You are free to think what you want");
		localCheersEnglish.Add ("Meet your goals");
		localCheersEnglish.Add ("Give your best");
		localCheersEnglish.Add ("Give without waiting for change");
		localCheersEnglish.Add ("Many people go through the same thing as you");
		localCheersEnglish.Add ("Before you speak, first listen");
		localCheersEnglish.Add ("Know your limits");
		localCheersEnglish.Add ("Visit your friends");

		// Cheerfull people
		localCheersEnglish.Add ("Do not wait until you are sure, take the risks");
		localCheersEnglish.Add ("Go for it, beers are not paid for alone");
		localCheersEnglish.Add ("Successes come from failures");
		localCheersEnglish.Add ("It could be worse");
		localCheersEnglish.Add ("Be patient");
		localCheersEnglish.Add ("When they bother you for being different, remember that they are the same");
		localCheersEnglish.Add ("Do not let your happiness depend on someone else");
		localCheersEnglish.Add ("After the storm comes the calm");
		localCheersEnglish.Add ("Get to where only eagles and angels can fly");
		localCheersEnglish.Add ("The key to change is freedom from fear");
		localCheersEnglish.Add ("The biggest barrier to success is fear of defeat");
		localCheersEnglish.Add ("No matter how long the storm is, the sun always shines again among the clouds");
		//Load cheers from server (async from heroku)
		//Set array of cheers
	}

	void Update ()
	{
		
	}

	public void SetLanguage (int l)
	{
		Language = l;
		Init();
	}

	public void Cheer ()
	{
		if (Language == 0)
		{
			//Roll the cheer in the screen
			int rand = Random.Range(0, localCheersSpanish.Count);
			letrero.GetComponent<Text>().text = localCheersSpanish[rand];
		}

		if (Language == 1)
		{
			//Roll the cheer in the screen
			int rand = Random.Range(0, localCheersEnglish.Count);
			letrero.GetComponent<Text>().text = localCheersEnglish[rand];
		}
	}

	public void Init()
	{
		if (Language == 0) { letrero.GetComponent<Text>().text = "Haz click abajo"; }
		if (Language == 1) { letrero.GetComponent<Text>().text = "Click below"; }
	}
}
