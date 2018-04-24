using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cajon_script : MonoBehaviour {
    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {
        //si coje el cajon se abre
        if (Input.GetKeyDown("1"))
        {
            anim.Play("abrir_cajon");
        }
        /*if (Input.GetKeyDown(KeyCode.C))
        {
            anim.Play("cerrar_cajon");
        }*/
    }
}
