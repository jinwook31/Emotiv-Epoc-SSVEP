using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour{
    private GameObject targ;

    // Start is called before the first frame update
    void Start(){
        targ = GameObject.FindGameObjectWithTag("target");

        InvokeRepeating("setRed", 0, 0.1f);
        InvokeRepeating("setWhite", 0.05f, 0.1f);
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void setRed(){
        var targRenderer = targ.GetComponent<Renderer>();
        targRenderer.material.SetColor("_Color", Color.red);
    }

    private void setWhite(){
        var targRenderer = targ.GetComponent<Renderer>();
        targRenderer.material.SetColor("_Color", Color.white);
    }
}
