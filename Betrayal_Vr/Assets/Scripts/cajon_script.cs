using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cajon_script : MonoBehaviour {
    public Animation anim;

	// Use this for initialization
	void Start () {
        		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.Play("abrir_cajon");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.Play("cerrar_cajon");
        }
    }
}
