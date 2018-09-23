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
    public GameObject p6;
    public GameObject p7;
    public GameObject p8;
    public GameObject p9;
    public GameObject p10;
    public GameObject p11;
    public GameObject p12;


    public GameObject present;

    private void Start()
    {
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
        p7.SetActive(false);
        p8.SetActive(false);
        p9.SetActive(false);
        p10.SetActive(false);
        p11.SetActive(false);
        p12.SetActive(false);
     
    }

    public void Next() {
        present.SetActive(false);
        Debug.Log("The name of this object is " + present.name);

            next.SetActive(true);
        Debug.Log("The name of this object is " + next.name);
    }
    






}
