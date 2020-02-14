using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrastraSuelta : MonoBehaviour
{
    float x, y, z;

    //float deltaMovimiento = 1f;
    //float constanteY = 1f;
     private Vector3 esferaInitialPos;
     private float mZcoordenadas;
     //Renderer rend;

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

            esferaInitialPos = Camera.main.ScreenToWorldPoint(new Vector3(x, y, z));
            gameObject.transform.position = esferaInitialPos;
        /*bool shouldContinue = false;

        do
        {
            print("Hello World");

        } while (shouldContinue == true);
        */

         //transform.position = new Vector3(1,0,1);
         //transform.position = GetMousePosicion() + esferaInitialPos;

        }
     

        private Vector3 GetMousePosicion()
         {
             Vector3 puntoMouse = Input.mousePosition;
             puntoMouse.z = mZcoordenadas;

             return Camera.main.ScreenToWorldPoint(puntoMouse);
         }


    private void OnCollisionEnter(Collision other)
    {
        /*
           col = GetComponent<MeshCollider>();
           constanteY = transform.position.y;
           if(col.Mes)
           {
            constanteY = 1f;
           }
          */

        //rasDePiso= transform.position; //acá quería dejar una altura
        Debug.Log("Collision");
        //Destroy(other.gameObject); //estoy probando, en vez que destruya que no traspase plane


    }

}
