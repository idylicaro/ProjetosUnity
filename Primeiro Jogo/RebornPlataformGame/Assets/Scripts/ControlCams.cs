using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCams : MonoBehaviour
{
    GameObject cameraJogo;

    //GameObject objetoPrincipal;
    void Start()
    {
        cameraJogo = GameObject.Find("CameraJogo");
        cameraJogo.SetActive(false);

      
    }
    public  void MudaCamera()
    {
        cameraJogo.SetActive(true);
        this.gameObject.SetActive(false);
        
    }

    


    }
