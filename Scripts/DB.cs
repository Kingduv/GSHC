using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DB : MonoBehaviour
{
    string ususario;
    string contraseña;
    public static string obj_compra="Moto Italika";
    public static float saldo=17912.50f;
    public static float precio=7000f;
    public static float descuento=5f;
    public static float creditosaldo=6356f;
    public static int logox;
    public static int panel;
    public static float interes = 5;
    public static string marca = "Italika" ;
    public static string tienda = "Elektra";
    public static bool compa=false;
    

    public Sprite[] logo;//0 Elektra , 1 Italika, 2 Banco Azteca
    
    public List<Meta> metas = new List<Meta>();
    public List<Presupuesto> presupuestos = new List<Presupuesto>();
    public List<IngEg> ie = new List<IngEg>();
    public List<string> semana= new List<string>();
    public static int n_logo;
    public int[] dia_mes = new int[31];
    public List<string> mes = new List<string>();
    public string[] mes_ano = 
        { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };



    private void Awake()
    {
        semana.Add("Lunes");
        semana.Add("Martes");
        semana.Add("Miercoles");
        semana.Add("Jueves");
        semana.Add("Viernes");
        semana.Add("Sabado");
        semana.Add("Domingo");
        foreach(string m in mes_ano)
        {
            mes.Add(m);
        }
        
        CreateMetas();
        CrearDatosIngEg();
       // CreatePresupuestos();
       
    }
    void CreateMetas()
    {
        Meta m = new Meta();
        
        m.m_nom = "Viaje Cancun";
        m.m_costo = 8000;
        m.m_cuota = 20;
        m.m_ahorro = 5180;
        metas.Add(m);

        //m = new Meta();
        //m.m_nom = "Auto";
        //m.m_costo = 90000;
        //m.m_cuota = 400;
        //m.m_ahorro = 80600;
        //metas.Add(m);
        
    }
    public void CrearDatosIngEg()
    {

        
       
            foreach (string d in semana)
            {
                if (!d.Equals("Domingo"))
                {
                    IngEg iE = new IngEg();
                    iE.value = Random.Range(5000, 150);
                    iE.tipoProyeccion = IngEg.Tipo.Semana;
                    ie.Add(iE);
                    //Debug.Log(iE.value);
                }
                else
                {
                    IngEg iE = new IngEg();
                    iE.value = 0;
                    iE.tipoProyeccion = IngEg.Tipo.Semana;
                    ie.Add(iE);
                    //Debug.Log(iE.value);
                }
            
            }
             
      
      //foreach(string m in mes_año)
      //  {
      //      IngEg iE = new IngEg();
      //      iE.value = Random.Range(1000, 150);
      //      iE.tipoProyeccion = IngEg.Tipo.Mes;
      //      ie.Add(iE);
      //  }
    }
    void CreatePresupuestos()
    {
        
        
    }
}
