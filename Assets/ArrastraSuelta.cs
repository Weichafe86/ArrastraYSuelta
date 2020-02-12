using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrastraSuelta : MonoBehaviour
{
   
    private Vector3 esferaInitialPos;
    private float mZcoordenadas;


    void OnMouseDown()
    {
        print("Mouse Down");
        mZcoordenadas = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;    
        esferaInitialPos = gameObject.transform.position - GetMousePosicion();
    }


    private void OnMouseDrag()
    {
        print("Mouse Drag");
        transform.position = GetMousePosicion() + esferaInitialPos; 
        

    }
  
    private Vector3 GetMousePosicion()
    {
        Vector3 puntoMouse = Input.mousePosition;
        puntoMouse.z = mZcoordenadas;

        return Camera.main.ScreenToWorldPoint(puntoMouse);
    }

}
