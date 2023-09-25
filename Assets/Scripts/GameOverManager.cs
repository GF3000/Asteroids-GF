using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour


{
    public GameObject textoPuntuacion;

    public GameObject cartelGameOver;
    // Start is called before the first frame update
    void Start()

    {
        cartelGameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarPuntuacion(int score)
    {
        cartelGameOver.SetActive(true);

        textoPuntuacion.GetComponent<Text>().text = "Puntuacion: " + score;
    }
}
