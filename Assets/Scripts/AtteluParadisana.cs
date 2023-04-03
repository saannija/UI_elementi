using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject bean, lacis, tante, masina, paK, paL;

	public void BeanAtt(bool v){
		bean.SetActive(v); //checkmark
		paK.GetComponent<Toggle>().interactable = v;
        paL.GetComponent<Toggle>().interactable = v;
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
	public void PaKreisiBean()
	{
		bean.transform.localScale = new Vector2(1, 1);
	}
    public void PaLabiBean()
    {
        bean.transform.localScale = new Vector2(-1, 1);
    }
}
