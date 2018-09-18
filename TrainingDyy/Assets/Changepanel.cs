using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changepanel : MonoBehaviour {
    public GameObject next;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;


    public GameObject present;

    private void Start()
    {
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
    }

    public void Next() {
        present.SetActive(false);
        Debug.Log("The name of this object is " + present.name);

            next.SetActive(true);
        Debug.Log("The name of this object is " + next.name);
    }
    






}
