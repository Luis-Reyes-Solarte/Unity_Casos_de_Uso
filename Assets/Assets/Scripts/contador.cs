using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contador : MonoBehaviour
{
    public static contador instance;
    public int contador_monedas = 0;
    public Text contadorText;
    // Start is called before the first frame update
    void Awake()
    {
        // Singleton para acceso global
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void SumarColeccionable()
    {
        contador_monedas++;
        contadorText.text = "Coins:" + contador_monedas;
    }
}
