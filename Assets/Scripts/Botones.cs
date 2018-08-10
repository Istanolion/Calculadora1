using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour {
    public Text texto;
    string linea;
    private void Awake()
    {
        linea = "";
    }
    public void Boton0()
    {
        if (linea != "")
        {
            linea = string.Concat(linea, "0");
            texto.text = linea;
        }
    }
    public void Boton1()
    {
        linea = string.Concat(linea, "1");
        texto.text = linea;
    }
    public void Boton2()
    {
        linea = string.Concat(linea, "2");
        texto.text = linea;
    }
    public void Boton3()
    {
        linea = string.Concat(linea, "3");
        texto.text = linea;
    }
    public void Boton4()
    {
        linea = string.Concat(linea, "4");
        texto.text = linea;
    }
    public void Boton5()
    {
        linea = string.Concat(linea, "5");
        texto.text = linea;
    }
    public void Boton6()
    {
        linea = string.Concat(linea, "6");
        texto.text = linea;
    }
    public void Boton7()
    {
        linea = string.Concat(linea, "7");
        texto.text = linea;
    }
    public void Boton8()
    {
        linea = string.Concat(linea, "8");
        texto.text = linea;
    }
    public void Boton9()
    {
        linea = string.Concat(linea, "9");
        texto.text = linea;
    }
    public void Boton10()
    {
        linea = string.Concat(linea, "A");
        texto.text = linea;
    }
    public void Boton11()
    {
        linea = string.Concat(linea, "B");
        texto.text = linea;
    }
    public void Boton12()
    {
        linea = string.Concat(linea, "C");
        texto.text = linea;
    }
    public void Boton13()
    {
        linea = string.Concat(linea, "D");
        texto.text = linea;
    }
    public void Boton14()
    {
        linea = string.Concat(linea, "E");
        texto.text = linea;
    }
    public void Boton15()
    {
        linea = string.Concat(linea, "F");
        texto.text = linea;
    }
    public void BotonPunto()
    {
        linea = string.Concat(linea, ".");
        texto.text = linea;
    }
}
