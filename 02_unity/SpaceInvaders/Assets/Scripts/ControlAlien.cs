using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ControlAlien : MonoBehaviour
{
	// Conexión al marcador, para poder actualizarlo
	private GameObject marcador;


	private int puntosazul = 250;
	private int puntosrojo = 200;
	private int puntosnegro = 150;
	private int puntosmarron = 100;

	// Objeto para reproducir la explosión de un alien
	private GameObject efectoExplosion;

	// Use this for initialization
	void Start ()
	{
		// Localizamos el objeto que contiene el marcador
		marcador = GameObject.Find ("Marcador");

		// Objeto para reproducir la explosión de un alien
		efectoExplosion = GameObject.Find ("EfectoExplosion");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		// Detectar la colisión entre el alien y otros elementos

		// Necesitamos saber contra qué hemos chocado
		if (coll.gameObject.tag == "disparo") {
			if (gameObject.tag == "alienazul") {
				
				// Sonido de explosión
				GetComponent<AudioSource> ().Play ();

				// Sumar la puntuación al marcador
				marcador.GetComponent<ControlMarcador> ().puntos += puntosazul;

				// El disparo desaparece (cuidado, si tiene eventos no se ejecutan)
				Destroy (coll.gameObject);

				// El alien desaparece (no hace falta retraso para la explosión, está en otro objeto)
				efectoExplosion.GetComponent<AudioSource> ().Play ();
				Destroy (gameObject);

			} else if (gameObject.tag == "alienrojo") {

				// Sonido de explosión
				GetComponent<AudioSource> ().Play ();

				// Sumar la puntuación al marcador
				marcador.GetComponent<ControlMarcador> ().puntos += puntosrojo;

				// El disparo desaparece (cuidado, si tiene eventos no se ejecutan)
				Destroy (coll.gameObject);

				// El alien desaparece (no hace falta retraso para la explosión, está en otro objeto)
				efectoExplosion.GetComponent<AudioSource> ().Play ();
				Destroy (gameObject);

			} else if (gameObject.tag == "aliennegro") {
				
				// Sonido de explosión
				GetComponent<AudioSource> ().Play ();

				// Sumar la puntuación al marcador
				marcador.GetComponent<ControlMarcador> ().puntos += puntosnegro;

				// El disparo desaparece (cuidado, si tiene eventos no se ejecutan)
				Destroy (coll.gameObject);

				// El alien desaparece (no hace falta retraso para la explosión, está en otro objeto)
				efectoExplosion.GetComponent<AudioSource> ().Play ();
				Destroy (gameObject);

			} else if (gameObject.tag == "alienmarron") {
				
				// Sonido de explosión
				GetComponent<AudioSource> ().Play ();

				// Sumar la puntuación al marcador
				marcador.GetComponent<ControlMarcador> ().puntos += puntosmarron;

				// El disparo desaparece (cuidado, si tiene eventos no se ejecutan)
				Destroy (coll.gameObject);

				// El alien desaparece (no hace falta retraso para la explosión, está en otro objeto)
				efectoExplosion.GetComponent<AudioSource> ().Play ();
				Destroy (gameObject);

			}


		} else if (coll.gameObject.tag == "nave") {
			
			GetComponent<AudioSource> ().Play ();
			efectoExplosion.GetComponent<AudioSource> ().Play ();

		}
	}
}
