using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalizaJuego : MonoBehaviour
{
    public GameObject personaje;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colisionado con: " + other.gameObject);
        if (other.gameObject == personaje)
        {
            canvas.SetActive(true);
        }
    }
}
