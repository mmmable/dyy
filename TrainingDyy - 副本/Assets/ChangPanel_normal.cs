using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangPanel_normal : MonoBehaviour {

    public GameObject next;
    public GameObject nextp;
    public GameObject back;
    public GameObject backp;
    public GameObject present;
    public GameObject presentp;

    private void Start()
    {
      //  present.SetActive(false);
    }


    public void Next()
    {
        present.SetActive(false);
        presentp.SetActive(false);
        next.SetActive(true);
        nextp.SetActive(true);
    }

    public void Back()
    {
        present.SetActive(false);
        presentp.SetActive(false);
        back.SetActive(true);
        backp.SetActive(true);

    }

}
