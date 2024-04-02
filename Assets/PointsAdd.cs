using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsAdd : MonoBehaviour
{
    public Player punto;
    private TextMeshProUGUI puntos;

    void Start()
    {
        puntos = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // Actualizar el texto con la cantidad actual de puntos
        puntos.text = "Coins: " + punto.score.ToString();
    }
}

