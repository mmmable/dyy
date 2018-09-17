using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cone : MonoBehaviour {

    private Vector3 pointButton1;
    private Vector3 pointButton2;
    private Vector3 pointCone;

    public GameObject cone;
    public GameObject button1;
    public GameObject button2;


	void Start () {

        cone.GetComponent<Renderer>().enabled = false;
		
	}
	

	void Update () {

        pointCone = gameObject.transform.position;           //实时获取物体的位置
        pointButton1 = button1.GetComponent<Transform>().position;      //实时获取购物车的位置
        pointButton2 = button2.GetComponent<Transform>().position;


        if (Vector3.Distance(pointButton1, pointCone) < 0.2) //判断以上两个位置之间的距离
        {
            cone.GetComponent<Renderer>().enabled = true;
        }

        if (Vector3.Distance(pointButton2, pointCone) < 0.2) //判断以上两个位置之间的距离
        {
            cone.GetComponent<Renderer>().enabled = true;
        }

        if (Vector3.Distance(pointButton1, pointCone) > 0.2 && Vector3.Distance(pointButton2, pointCone) > 0.2) //判断以上两个位置之间的距离
      
            cone.GetComponent<Renderer>().enabled = false;
        }


    }



