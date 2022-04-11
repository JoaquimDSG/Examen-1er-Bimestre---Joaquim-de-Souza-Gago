using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examen1 : MonoBehaviour
{
    public int Monto;
    public string Moneda;
    int resultado;
    
    // Start is called before the first frame update
    void Start()
    {
        if (Monto < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
        }

        else if (Moneda == "D" && Monto >= 1000)
        {
            resultado = (Monto / 112);
            Debug.Log(Monto + " pesos argentinos equivalen a " + resultado + " dolares");
        }

        else if (Moneda == "R" && Monto >= 1000)
        {
            resultado = (Monto / 23);
            Debug.Log(Monto + " pesos argentinos equivalen a " + resultado + " reales");
        }

        else if (Moneda == "E" && Monto >= 1000)
        {
            resultado = (Monto / 122);
            Debug.Log(Monto + " pesos argentinos equivalen a " + resultado + " euros");
        }

        else if (Moneda != "D" && Moneda != "R" && Moneda != "E")
        {
            Debug.Log("Opción de moneda extranjera no válida");
        } 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
