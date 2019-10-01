using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pegaItemsound : MonoBehaviour
{
    public GameObject ovoSoundObject;
    public GameObject penaSoundObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void pegaovosound()
    {
        ovoSoundObject.GetComponent<AudioSource>().Play();
    }
    void pegaPenasound() {
        penaSoundObject.GetComponent<AudioSource>().Play();
}
}
