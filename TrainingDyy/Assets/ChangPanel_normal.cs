using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangPanel_normal : MonoBehaviour {

        public GameObject next;
        public GameObject back;
        public GameObject present;

    private void Start()
    {
      //  present.SetActive(false);
    }


    public void Next()
        {
            present.SetActive(false);
            next.SetActive(true);
        }
        public void Back()
        {
            present.SetActive(false);
            back.SetActive(true);

        }
    }
