using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logica : MonoBehaviour {
    Queue<int> enteros= new Queue<int>();
    Stack<int> decimales = new Stack<int>();
    int Numero = 0;
    float deci=0,transformacion;
    string texto;
    public void AgregarEntero(int num)
    {
        enteros.Enqueue(num);
    }
    public void AgregarDecimal(int num)
    {
        decimales.Push(num);
    }
    public string XtoDec(string basnum)
    {
        int basenum=0;
        switch (basnum)
        {
            case ("Decimal"):
                basenum = 10;
                break;
            case ("Binario"):
                basenum = 2;
                break;
            case ("Octal"):
                basenum = 8;
                break;
            case ("Hexa"):
                basenum = 16;
                break;
        }
        for(int i = enteros.Count-1; i >= 0; i--)
        {
            Numero += (int)Mathf.Pow(basenum, i) * enteros.Dequeue();
        }
        for(int i = decimales.Count; i >= 1; i--)
        {
            deci += Mathf.Pow(basenum, -i) * decimales.Pop();
        }
        texto = "";
        if (deci != 0)
        {
            texto = deci.ToString();
            texto = texto.Substring(1);
        }
        texto= string.Concat(Numero.ToString(),texto);
        transformacion = Numero + deci;
        Numero = 0;
        deci = 0;
        return texto;
    }
    public string XtoHex(string basnum)
    {
        XtoDec(basnum);
        int entero = Mathf.FloorToInt(transformacion);
        transformacion -= entero;
        Stack<string> chars = new Stack<string>();
        do
        {
            if (entero % 16 < 10)
            {
                int num = entero % 16;
                chars.Push(num.ToString());
            }
            else
            {
                int num = entero % 16;
                switch (num)
                {
                    case (10):
                        chars.Push("A");
                        break;
                    case (11):
                        chars.Push("B");
                        break;
                    case (12):
                        chars.Push("C");
                        break;
                    case (13):
                        chars.Push("D");
                        break;
                    case (14):
                        chars.Push("E");
                        break;
                    case (15):
                        chars.Push("F");
                        break;
                }
            }
            entero = Mathf.FloorToInt(entero / 16);
        } while (entero > 15);
        chars.Push(entero.ToString());
        Queue<string> let = new Queue<string>();
        int i = 0;
        do
        {
            transformacion *= 16;
            int num = Mathf.FloorToInt(transformacion);
            transformacion -= num;
            if(num<10)
                let.Enqueue(num.ToString());
            else
            {
                switch (num)
                {
                    case (10):
                        let.Enqueue("A");
                        break;
                    case (11):
                        let.Enqueue("B");
                        break;
                    case (12):
                        let.Enqueue("C");
                        break;
                    case (13):
                        let.Enqueue("D");
                        break;
                    case (14):
                        let.Enqueue("E");
                        break;
                    case (15):
                        let.Enqueue("F");
                        break;
                }
            }
            i++;
        } while (i<5);
        texto = "";
        for (i = chars.Count; i >0 ; i--)
        {
            texto = string.Concat(texto, chars.Pop());
        }
        texto = string.Concat(texto, ".");
        for (i=let.Count;i>0;i--)
        {
            texto = string.Concat(texto, let.Dequeue());
        }
        return texto;
    }
    public string XtoOct(string basnum)
    {
        XtoDec(basnum);
        int entero = Mathf.FloorToInt(transformacion);
        transformacion -= entero;
        Stack<string> chars = new Stack<string>();
        do
        {
            if (entero % 8 < 8)
            {
                int num = entero % 8;
                chars.Push(num.ToString());
            }
            entero = Mathf.FloorToInt(entero / 8);
        } while (entero > 7);
        chars.Push(entero.ToString());
        Queue<string> let = new Queue<string>();
        int i = 0;
        do
        {
            transformacion *= 8;
            int num = Mathf.FloorToInt(transformacion);
            transformacion -= num;
            if (num < 8)
                let.Enqueue(num.ToString());
            i++;
        } while (i < 5);
        texto = "";
        for (i = chars.Count; i > 0; i--)
        {
            texto = string.Concat(texto, chars.Pop());
        }
        texto = string.Concat(texto, ".");
        for (i = let.Count; i > 0; i--)
        {
            texto = string.Concat(texto, let.Dequeue());
        }
        return texto;
    }
    public string XtoBin(string basnum)
    {
        XtoDec(basnum);
        int entero = Mathf.FloorToInt(transformacion);
        transformacion -= entero;
        Stack<string> chars = new Stack<string>();
        do
        {
            if (entero % 2 < 2)
            {
                int num = entero % 2;
                chars.Push(num.ToString());
            }
            entero = Mathf.FloorToInt(entero / 2);
        } while (entero > 1);
        chars.Push(entero.ToString());
        Queue<string> let = new Queue<string>();
        int i = 0;
        do
        {
            transformacion *= 2;
            int num = Mathf.FloorToInt(transformacion);
            transformacion -= num;
            if (num < 2)
                let.Enqueue(num.ToString());
            i++;
        } while (i < 5);
        texto = "";
        for (i = chars.Count; i > 0; i--)
        {
            texto = string.Concat(texto, chars.Pop());
        }
        texto = string.Concat(texto, ".");
        for (i = let.Count; i > 0; i--)
        {
            texto = string.Concat(texto, let.Dequeue());
        }
        return texto;
    }
}
