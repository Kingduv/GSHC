using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class SceneM : MonoBehaviour
{
    
    public void OpenCompras(GameObject obj)
    {
        
        DB.obj_compra = "Moto";//nombre
        DB.precio = 745.45f;//precio
        DB.descuento = 10f;//descuento
        DB.n_logo=1;//numero de logo
        DB.panel = 8;
        SceneManager.LoadScene(2);
    }

    
    public void OpenAR()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenOperaciones(int x)
    {
        SceneManager.LoadScene(2);
        if (x != 5)
        {
            DB.panel = x;
        }
        else
        {
            DB.panel = 5;
            OpenAR();
        }
        
    }
    public void OpenExito()
    {
        DB.panel = 7;
        DB.compa = true;
        SceneManager.LoadScene(2);        
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
