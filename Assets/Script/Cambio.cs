using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cambio : MonoBehaviour
{
    public GameObject panel;
    public GameObject text;


    private void Start()
    {
        panel.SetActive(false);
        
    }



    public void Button_Click()
    {
        
        if (panel!=null)
        {
            panel.SetActive(true);
            text.SetActive(false);
        }
       
        
    }
}
