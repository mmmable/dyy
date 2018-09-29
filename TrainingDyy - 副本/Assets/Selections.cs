using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selections : MonoBehaviour {

    //public AudioClip clip;

    void Start () {
		
	}
	
	void Update () {
		
	}

    public void TocolorA()
    {
        transform.GetComponent<MeshRenderer>().materials[0].color = Color.red; //transform.GetComponent<MeshRenderer>().materials[1].color = Color.red;颜色变成红色
        //AudioSource.PlayClipAtPoint(clip, transform.position); //音效
    }

    public void TocolorB()
    {
        transform.GetComponent<MeshRenderer>().materials[0].color = Color.blue;
        //AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void TocolorC()
    {
        transform.GetComponent<MeshRenderer>().materials[0].color = Color.green;
        //AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void ToS()
    {
        transform.localScale = new Vector3(0.1F, 0.1F, 0.1F); //transform.localScale = new Vector3(0.5F, 0.5F, 0.5F)
        //AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void ToM()
    {
        transform.localScale = new Vector3(0.25F, 0.25F, 0.25F);
        //AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void ToL()
    {
        transform.localScale = new Vector3(0.5F, 0.5F, 0.5F);
        //AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
