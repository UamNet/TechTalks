using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Persona : MonoBehaviour {
    public string nombre;
    public string apellido;
    public string frase;
    // Use this for initialization
    Text texto;
    void Start () {
        texto = GetComponent<Text>();
        texto.text = "Me llamo "+ nombre + " "+ apellido + " Mi frase es: " + frase;
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}


}
