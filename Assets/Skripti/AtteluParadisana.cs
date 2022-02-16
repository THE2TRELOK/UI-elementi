using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana : MonoBehaviour {
	public GameObject bins;
	public GameObject lacis;
	public GameObject tante;
	public GameObject masina;

	public void binaAttelosana(bool vertiba){
		bins.SetActive (vertiba);

	}
	public void MasinasAttelosana(bool vertiba){
		masina.SetActive (vertiba);

	}
	public void TantesAttelosana(bool vertiba){
		tante.SetActive (vertiba);

	}
	public void LacisaAttelosana(bool vertiba){
		lacis.SetActive (vertiba);

	}
	public void palabiBins(){
		bins.transform.localScale = new Vector2 (-1,1);
}
	public void pakreisiBins(){
		bins.transform.localScale = new Vector2 (1,1);
	}
}
