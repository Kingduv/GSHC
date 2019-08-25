using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProspComp : MonoBehaviour
{
    public void OpenCompras(GameObject c)
    {
        c.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
