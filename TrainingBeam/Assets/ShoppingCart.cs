﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingCart : MonoBehaviour {

    private Vector3 pointZero;
    private Vector3 pointCart;
    private Vector3 pointMove;
    public GameObject Cart;
    public MoveCube other;
    
    //public AudioClip clip;


    void Start () {
        pointZero = transform.position;
    }

    public void Update () {
        pointMove = gameObject.transform.position;           //实时获取物体的位置
        pointCart = Cart.GetComponent<Transform>().position; //实时获取购物车的位置


        if (Vector3.Distance(transform.position, pointCart) < 0.1)
        {
            Cart.GetComponent<MeshRenderer>().materials[0].color = Color.black;
            gameObject.SetActive(false);                                     //销毁物体
                                                                             //AudioSource.PlayClipAtPoint(clip, transform.position);   //音效

            Invoke("Showthecube", 2);
        }   
    }

    public void Showthecube()
        {
            other.Move();
        }
}
