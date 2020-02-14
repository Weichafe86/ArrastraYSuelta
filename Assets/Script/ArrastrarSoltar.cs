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

    }


}
