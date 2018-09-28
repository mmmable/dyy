using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changepanel : MonoBehaviour {
    public GameObject next;
    public GameObject nextp;
    public GameObject present;
    public GameObject presentp;

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

    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public GameObject c5;
    public GameObject c6;
    public GameObject c7;
    public GameObject c8;
    public GameObject c9;
    public GameObject c10;
    public GameObject c11;
    public GameObject c12;




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

        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(false);
        c5.SetActive(false);
        c6.SetActive(false);
        c7.SetActive(false);
        c8.SetActive(false);
        c9.SetActive(false);
        c10.SetActive(false);
        c11.SetActive(false);
        c12.SetActive(false);

    }

    public void Next() {
        present.SetActive(false);
        presentp.SetActive(false);
        next.SetActive(true);
        nextp.SetActive(true);
    }
    






}
