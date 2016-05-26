using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ControlInicio : MonoBehaviour {

	public void unjugador(){
		SceneManager.LoadScene(0);
	
	}

	public void dosjugadores(){
		SceneManager.LoadScene(2);

	}


}
