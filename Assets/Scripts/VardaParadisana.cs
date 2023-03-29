using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	/*
	int kadrs=0;
	// Use this for initialization
	void Start () {
		Debug.Log ("Starteta programma");
	}
	
	// Update is called once per frame
	void Update () {
		kadrs++;
		Debug.Log ("Kadrs: "+kadrs);
	}
	*/
	//mainigais kura ieglabas tekstu no input field
	private string txt;
	private string[] varianti = {"Sveiks","Jauku dienu", "Prieks Tevi redzet","Uzredzesanos"};
	int rand;
	//ievada tekstu
	public GameObject input;
	public GameObject txtShow;
	public void savedTxt(){
		rand=Random.Range(0, varianti.Length);
		txt=input.GetComponent<Text> ().text;
		txtShow.GetComponent<Text> ().text = varianti [rand] + txt.ToUpper () + "!";
	}
}
