using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CambioBotones : MonoBehaviour
{
    public GameObject[] butts;
    public Sprite[] npressed;
    public Sprite[] pressed;

    //public Sprite pressed;

    public void Cambio(int p)
    {
        int i = 0;
        foreach(GameObject but in butts)
        {
            but.GetComponent<Image>().sprite = npressed[i];
            i++;
        }
        butts[p].GetComponent<Image>().sprite = pressed[p];
      
        
    }
}
