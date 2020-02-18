using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarImagen : MonoBehaviour
{
    public GameObject foto1;
    public GameObject foto2;
    public GameObject txtCirculo;
    public GameObject txtCorrecto;

    private void Start()
    {
        foto1.SetActive(false);
        foto2.SetActive(false);
        txtCirculo.SetActive(false);
        txtCorrecto.SetActive(false);
    }

    public void Update()
    {
        bool imag1 = Input.GetKey(KeyCode.W);
        bool imag2 = Input.GetKey(KeyCode.A);
        bool txtCir = Input.GetKey(KeyCode.S);
        bool txtCorr = Input.GetKey(KeyCode.D);

        if (imag1){
            foto1.SetActive(true);
        }

        if (imag2){
            foto2.SetActive(true);
        }

        if (txtCir){
            txtCirculo.SetActive(true);
        }

        if (txtCorr){
            txtCorrecto.SetActive(true);
        }


    }
}
