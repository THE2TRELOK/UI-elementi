using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {
	//Uzglabas tekstu kurs panemts No input lauka
	public string teksts;
	//Lauks no kura es tekstu panemsu
	public GameObject ievadesLauks;
	//Teksta objektsm kur attelot mainiga teksts saturu
	public GameObject tekstaAttelosanasLauks;

	public void darbibasArTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		tekstaAttelosanasLauks.GetComponent<Text>().text= "Sveiks "+teksts.ToUpper()+"!";
	}
	

}
