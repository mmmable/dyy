using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changepanel : MonoBehaviour {
    public GameObject next;
   
    public GameObject present;

	public void Next() {
        present.SetActive(false);
            next.SetActive(true);
	}
    






}
