using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHueso : MonoBehaviour
{
    public GameObject personaje;

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
            personaje.GetComponent<PersonajeMovimiento>().sobreHueso();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == personaje)
        {
            personaje.GetComponent<PersonajeMovimiento>().abandonaHueso();
        }
    }
}
