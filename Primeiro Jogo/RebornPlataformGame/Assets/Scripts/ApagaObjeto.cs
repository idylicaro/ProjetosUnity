using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagaObjeto : MonoBehaviour
{
    private float tempo = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroiObjeto", tempo);
    }

    // Update is called once per frame
    void  destroiObjeto()
    {
        Destroy(this.gameObject);
    }
}
