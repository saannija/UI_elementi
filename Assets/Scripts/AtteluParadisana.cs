using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana : MonoBehaviour {
	public GameObject bean, lacis, tante, masina;

	public void BeanAtt(bool v){
		bean.SetActive(v); //checkmark
	}
	public void GrannyAtt(bool v){
		tante.SetActive(v); //checkmark
	}
	public void CarAtt(bool v){
		masina.SetActive(v); //checkmark
	}
	public void TeddyAtt(bool v){
		lacis.SetActive(v); //checkmark
	}
}
