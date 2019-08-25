using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PanelM : MonoBehaviour
{
    public GameObject[] mainPannels;
    public TextMeshProUGUI[] saldo;
    
    private void Start()
    {
        foreach(GameObject m in mainPannels)
        {
            m.SetActive(false);
        }
        if (SceneManager.GetActiveScene().name.Equals("Compras"))
        {
            mainPannels[DB.panel-1].SetActive(true);
            
        }else if (SceneManager.GetActiveScene().name.Equals("Menu"))
        {
            ActivePannel(mainPannels[0]);
        }

        
        
        
        foreach(TextMeshProUGUI s in saldo)
        {
            s.text = "$" + DB.saldo;
        }
        
        
    }

    public void ChangePanel(int p)
    {
        DB.panel = p;
    }

   
    public void ActivePannel(GameObject p)
    {        
        foreach(GameObject b in mainPannels)
        {
            b.SetActive(false);
        }
        p.SetActive(true);       
        
    }
    

}
