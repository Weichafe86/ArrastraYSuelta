using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrastrarSoltar : MonoBehaviour
{
    float x, y, z;
    Vector3 esferaInitialPos;
    private float mZcoordenadas;


    void OnMouseDown()
    {
        print("Mouse Down");
        mZcoordenadas = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        esferaInitialPos = gameObject.transform.position - GetMousePosicion();
    }

   
    private Vector3 GetMousePosicion()
    {
        Vector3 puntoMouse = Input.mousePosition;
        puntoMouse.y = mZcoordenadas;
        return Camera.main.ScreenToWorldPoint(puntoMouse);

    }

    private void OnMouseDrag()
    {
        x = Input.mousePosition.x;
       y = gameObject.transform.position.z;
        z = Input.mousePosition.y;

        esferaInitialPos = Camera.main.ScreenToWorldPoint(new Vector3(x, y, z));
        esferaInitialPos.y = 0;
        gameObject.transform.position = esferaInitialPos;

        // esferaInitialPos = Camera.main.ScreenToWorldPoint(new Vector3(x,y,z));
        //gameObject.transform.position = esferaInitialPos;// hace que la esfera sea "arrastrada" por el mouse
    }


    /*
    private void OnMouseUp()
    {
        
        Transform trans = GetComponent<Transform>();

        transform.Translate(1, 0, 1);
           //transform.position = GetMousePosicion();
      //trans.position = trans.Translate(Vector3(1,0,1));
        Debug.Log("Mouse Up!");
        
    }
    */

        /*
       private void OnMouseDrag()
       {

           transform.position = GetMousePosicion() + esferaInitialPos; //posicion de la esfera

       }

       */

    /*
        private void OnCollisionEnter(Collision collision)
       { 
            
            do
            {
                //Mantener la esfera en el eje Y

            } while ("pelota toque plane dejar eje Y estático");
            
       }
       */


}
