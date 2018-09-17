using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cone : MonoBehaviour {

    private Vector3 pointButton;
    private Vector3 pointCone;

    public GameObject cone;
    public GameObject button1;


	void Start () {
        cone.SetActive(false);
		
	}
	

	void Update () {

        pointCone = gameObject.transform.position;           //实时获取物体的位置
        pointButton = button1.GetComponent<Transform>().position; //实时获取购物车的位置

        if (Vector3.Distance(pointButton, pointCone) < 1) //判断以上两个位置之间的距离
        {
            cone.SetActive(true);
        }

        if (Vector3.Distance(pointButton, pointCone) >= 1) //判断以上两个位置之间的距离
        {
            cone.SetActive(false);
        }

    }
}
