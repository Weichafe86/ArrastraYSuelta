using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrastrarSoltar : MonoBehaviour
{
    float x, y, z;
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
      
        x = Input.mousePosition.x;
        y = Input.mousePosition.y;
        z = gameObject.transform.position.z;
        
        esferaInitialPos = Camera.main.ScreenToWorldPoint(new Vector3(x,y,z));
        gameObject.transform.position = esferaInitialPos;
        Debug.Log(gameObject.name);
        //transform.position = new Vector3(1, 0, 1);
        //transform.position = GetMousePosicion() + esferaInitialPos;

    }


    private Vector3 GetMousePosicion()
    {
        Vector3 puntoMouse = Input.mousePosition;
        puntoMouse.z = mZcoordenadas;

        return Camera.main.ScreenToWorldPoint(puntoMouse);
    }
    
   // private void OnCollisionEnter(Collision collision)
    //{
        /*
        do
        {
            //Mantener la esfera en el eje Y

        } while ("pelota toque plane dejar eje Y estático");
        */
   // }



}
