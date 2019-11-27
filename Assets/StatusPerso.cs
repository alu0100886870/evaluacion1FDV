using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusPerso : MonoBehaviour
{
    public int vida = 100;
    public int puntos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damage()
    {
        vida -= 10;
    }

    public void addPuntos(int puntos)
    {
        this.puntos += puntos;
    }
}
