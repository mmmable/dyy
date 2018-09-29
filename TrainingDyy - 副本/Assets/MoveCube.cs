﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {


    public GameObject c1;
    public GameObject cart;
    public Vector3 a;
    public Vector3 startPos;
    public Material red;

   // public targetPosition:Vector3=Vector3(10,0,0);//指定位置

    // Use this for initialization
    void Start () {
        // c1.SetActive(true);
        a = c1.transform.position;
        startPos = transform.localScale;
    }
	
	// Update is called once per frame
	void Update () {
       

    }

    public void Move()
    {
        // transform.position = Vector3.MoveTowards(transform.position, a, Time.deltaTime * 2);//移动到指定位置
        c1.SetActive(true);
        c1.transform.position = a;
        c1.transform.rotation = Quaternion.identity;
        c1.transform.localScale = startPos;
        c1.GetComponent<MeshRenderer>().materials[0].color = Color.white;
        cart.GetComponent<MeshRenderer>().materials[0].color = new Color32(139,38,53,255);



    }
}
