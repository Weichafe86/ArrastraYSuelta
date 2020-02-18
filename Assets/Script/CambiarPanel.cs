using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarPanel : MonoBehaviour
{
    public GameObject PrimerPanel;
    public GameObject SegundoPanel;
    public GameObject TercerPanel;
    public GameObject CuartoPanel; 

    // Start is called before the first frame update
    void Start()
    {
        PrimerPanel.SetActive(false);
        SegundoPanel.SetActive(false);
        TercerPanel.SetActive(false);
        CuartoPanel.SetActive(false);
    }


    public void AbrirPanel()
    {
        if(PrimerPanel != null)
        {
            PrimerPanel.SetActive(true);
        }

        if (SegundoPanel != null)
        {
            SegundoPanel.SetActive(true);
        }

        if (TercerPanel != null)
        {
            TercerPanel.SetActive(true);
        }

        if (CuartoPanel != null)
        {
            CuartoPanel.SetActive(true);
        }
    }
    

    
    
}
