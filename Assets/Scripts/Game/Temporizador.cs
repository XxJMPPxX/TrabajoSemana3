using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temporizador : MonoBehaviour
{
    private float tiempoTranscurrido;
    private TextMeshProUGUI textoTemporizador;

    void Start()
    {
        tiempoTranscurrido = 0f;
        textoTemporizador = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;
        textoTemporizador.text = "Time: " + tiempoTranscurrido.ToString("F2");
    }
}
