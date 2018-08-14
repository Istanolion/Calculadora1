using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour {
    public Text texto,texto2;
    string linea, Base;
    public Logica logic;
    public GameObject Bina, Octa, Deca, Hexa;
    private void Awake()
    {
        linea = "";
        Base = "Decimal";
        Bina.SetActive(false);
        Octa.SetActive(false);
        Hexa.SetActive(false);
    }
    public void Boton0()
    {
        if (linea != "" ||linea.Length<15 )
        {
                linea = string.Concat(linea, "0");
                texto.text = linea;
                AgregarNum(0);
        }
    }
    public void Boton1()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "1");
            texto.text = linea;
            AgregarNum(1);
        }
    }
    public void Boton2()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "2");
            texto.text = linea;
            AgregarNum(2);
        }
    }
    public void Boton3()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "3");
            texto.text = linea;
            AgregarNum(3);
        }
    }
    public void Boton4()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "4");
            texto.text = linea;
            AgregarNum(4);
        }
    }
    public void Boton5()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "5");
            texto.text = linea;
            AgregarNum(5);
        }
    }
    public void Boton6()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "6");
            texto.text = linea;
            AgregarNum(6);
        }
    }
    public void Boton7()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "7");
            texto.text = linea;
            AgregarNum(7);
        }
    }
    public void Boton8()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "8");
            texto.text = linea;
            AgregarNum(8);
        }
    }
    public void Boton9()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "9");
            texto.text = linea;
            AgregarNum(9);
        }
    }
    public void Boton10()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "A");
            texto.text = linea;
            AgregarNum(10);
        }
    }
    public void Boton11()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "B");
            texto.text = linea;
            AgregarNum(11);
        }
    }
    public void Boton12()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "C");
            texto.text = linea;
            AgregarNum(12);
        }
    }
    public void Boton13()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "D");
            texto.text = linea;
            AgregarNum(13);
        }
    }
    public void Boton14()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "E");
            texto.text = linea;
            AgregarNum(14);
        }
    }
    public void Boton15()
    {
        if (linea.Length < 15)
        {
            linea = string.Concat(linea, "F");
            texto.text = linea;
            AgregarNum(15);
        }
    }
    public void BotonPunto()
    {
        if (linea.Length < 15 && !linea.Contains("."))
        {
            linea = string.Concat(linea, ".");
            texto.text = linea;
        }
    }
    public void Decimal()
    {
        if (linea.Length == 0)
        {
            GameObject.Find(Base).SetActive(false);
            Deca.SetActive(true);
            Base = "Decimal";
        }
        else
        {
            texto2.text = logic.XtoDec(Base);
            Clear();
        }
    }
    public void Bin()
    {
        if (linea.Length == 0)
        {
            GameObject.Find(Base).SetActive(false);
            Bina.SetActive(true);
            Base = "Binario";
        }
        else
        {
            texto2.text = logic.XtoBin(Base);
            Clear();
        }
    }
    public void Oct()
    {
        if (linea.Length == 0)
        {
            GameObject.Find(Base).SetActive(false);
            Octa.SetActive(true);
            Base = "Octal";
        }
        else
        {
            texto2.text = logic.XtoOct(Base);
            Clear();
        }
    }
    public void Hex()
    {
        if (linea.Length == 0)
        {
            GameObject.Find(Base).SetActive(false);
            Hexa.SetActive(true);
            Base = "Hexa";
        }
        else
        {
            texto2.text = logic.XtoHex(Base);
            Clear();
        }
    }
   public  void Clear()
    {
        linea = "";
        texto.text = linea;
    }
    void AgregarNum(int num)
    {
        if (linea.Contains("."))
        {
            logic.AgregarDecimal(num);
        }
        else
            logic.AgregarEntero(num);
    }
}
