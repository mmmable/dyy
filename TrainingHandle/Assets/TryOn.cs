using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//手柄
public class TryOn : MonoBehaviour
{

    private Vector3 pointZero;
    private Vector3 pointCart;
    private Vector3 pointMove;
    public GameObject Cart;
    // public GameObject c1;
    public GameObject c1;
    public Vector3 a;
    public Vector3 startPos;

    //public AudioClip clip;


    void Start()
    {
        pointZero = c1.transform.position;
    }

    public void Update()
    {
        pointMove = c1.transform.position;           //实时获取物体的位置
        pointCart = Cart.GetComponent<Transform>().position; //实时获取购物车的位置


        if (Vector3.Distance(pointMove, pointCart) < 0.15)
        {
            Debug.Log("物体快要消失了");
            c1.SetActive(false);                                    //销毁物体
            Debug.Log("物体现在消失了");                                                      //AudioSource.PlayClipAtPoint(clip, transform.position);   //音效

            Invoke("Showthecube", 2);
        }
    }
    public void Showthecube()
    {
        Debug.Log("showTheCube'函数被调用了");
        c1.SetActive(true);
        c1.transform.position = pointZero;
        c1.transform.rotation = Quaternion.identity;
        c1.transform.localScale = startPos;
    }
    //public void Delayshowthecube()
    // {

    //print(Time.time);
    //   Invoke("Showthecube", 2);
    //print(Time.time);


    //Debug.Log("invokeTest");



    // }
}
