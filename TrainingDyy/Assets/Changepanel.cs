using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changepanel : MonoBehaviour {
    public GameObject next;
   
    public GameObject present;

	public void Next() {
        present.SetActive(false);
        Debug.Log("The name of this object is " + present.name);

            next.SetActive(true);
        Debug.Log("The name of this object is " + next.name);
    }
    






}
